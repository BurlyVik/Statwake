using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statwake
{
    /// <summary>
    /// Config UI event handling
    /// </summary>

    public partial class Config : Form
    {
        private readonly ConfigFile _configFile;
        private readonly LogService _logger;
        private readonly SaveProfileService _saveProfileService;
        private readonly CharacterProfileRepository _characterRepository;
        private readonly OverlayManager _overlayManager;
        private readonly FileMonitor _fileMonitor;
        private readonly TooltipService _tooltipService;

        private string _activeSaveFilePath = string.Empty;

        public Config()
        {
            InitializeComponent();

            _configFile = new ConfigFile();
            _logger = new LogService(rtbStatusLog);
            _saveProfileService = new SaveProfileService(_logger);
            _characterRepository = new CharacterProfileRepository(_logger);
            _overlayManager = new OverlayManager();
            _tooltipService = new TooltipService();

            _fileMonitor = new FileMonitor(
                intervalMilliseconds: 1000,
                onFileChanged: HandleSaveFileChangedAsync);

            LoadConfigSettings();
        }


        /// <summary>
        /// Config
        /// </summary>

        private void LoadConfigSettings()
        {
            string savedPath = _configFile.ReadSaveFilePath();

            if (string.IsNullOrEmpty(savedPath))
                return;

            if (!File.Exists(savedPath))
                return;

            _activeSaveFilePath = savedPath;

            _logger.Post(
                Path.GetDirectoryName(_activeSaveFilePath),
                "Directory Found from Config");

            _logger.Post(
                Path.GetFileName(_activeSaveFilePath),
                "File Loaded from Config");

            LoadSaveFile(_activeSaveFilePath);
        }


        private void LoadSaveFile(string filePath)
        {
            _saveProfileService.ParseSaveFile(filePath);
            LoadCharacters();
        }


        /// <summary>
        /// File browser config
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDialogBrowse_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                string eldenAppDataPath = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.ApplicationData),
                    "EldenRing");

                dialog.Filters.Add(
                    new CommonFileDialogFilter("SL2 Files", "*.sl2"));

                if (Directory.Exists(eldenAppDataPath))
                    dialog.InitialDirectory = eldenAppDataPath;

                if (dialog.ShowDialog() != CommonFileDialogResult.Ok)
                    return;

                _activeSaveFilePath = dialog.FileName;

                _configFile.SaveFilePath = _activeSaveFilePath;

                _logger.Post(
                    Path.GetDirectoryName(_activeSaveFilePath),
                    "Directory Found");

                _logger.Post(
                    Path.GetFileName(_activeSaveFilePath),
                    "File Loaded");

                LoadSaveFile(_activeSaveFilePath);
            }
        }


        /// <summary>
        /// Character data
        /// </summary>

        private void LoadCharacters()
        {
            object previousSelection = cmbCharacters.SelectedItem;

            _characterRepository.Load();

            cmbCharacters.Items.Clear();

            foreach (CharacterProfile character in _characterRepository.Characters)
            {
                if (!character.IsActive || character.Name == null)
                    continue;

                cmbCharacters.Items.Add(character.SlotIndex);
            }

            if (previousSelection != null &&
                cmbCharacters.Items.Contains(previousSelection))
            {
                cmbCharacters.SelectedItem = previousSelection;
            }

            LogCharacters();
        }


        private void LogCharacters()
        {
            _logger.Post(
                _characterRepository.Characters.Count.ToString(),
                "Active characters loaded");

            foreach (CharacterProfile character in _characterRepository.Characters)
            {
                if (!character.IsActive || character.Name == null)
                    continue;

                _logger.Post(
                    $"Slot {character.SlotIndex}: {character.Name.Value}",
                    "Character Found");

                _logger.Post(
                    $"Level: {character.Level.Value} | " +
                    $"Deaths: {character.DeathCount.Value} | " +
                    $"Time: {character.Playtime.Value}",
                    "Stats");

                _logger.Post(
                    $"Global: {character.Name.GlobalOffset} | " +
                    $"Block: {character.Name.BlockOffset} | " +
                    $"Size: {character.Name.ByteSize} | " +
                    $"Bit: {character.Name.BitWidth} | " +
                    $"Type: {character.Name.DataType}",
                    "Offsets");
            }
        }


        private void cmbCharacters_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbCharacters.SelectedItem == null)
                return;

            CharacterProfile character =
                _characterRepository.FindBySlot(
                    cmbCharacters.SelectedItem);

            if (character == null)
                return;

            DisplayCharacter(character);
            StartFileMonitoring();
        }


        private void DisplayCharacter(CharacterProfile character)
        {
            if (!character.IsActive || character.Name == null)
                return;

            txbName.Text = $"{character.Name.Value}";
            txbLevel.Text = $"{character.Level.Value}";
            txbDeaths.Text = $"{character.DeathCount.Value}";
            txbTime.Text = $"{character.Playtime.Value}";

            txbGlobalOffset.Text = $"{character.Name.GlobalOffset}";
            txbBlockOffset.Text = $"{character.Name.BlockOffset}";
            txbByteSize.Text = $"{character.Name.ByteSize}";
            txbBitWidth.Text = $"{character.Name.BitWidth}";
            txbDataType.Text = $"{character.Name.DataType}";

            UpdateOverlay();
        }


        private void RefreshActiveCharacterDisplay()
        {
            if (cmbCharacters.SelectedIndex == -1)
                return;

            CharacterProfile character =
                _characterRepository.FindBySlot(
                    cmbCharacters.SelectedItem);

            if (character == null)
                return;

            DisplayCharacter(character);
        }


        /// <summary>
        ///  File Monitoring
        /// </summary>

        private void StartFileMonitoring()
        {
            if (string.IsNullOrEmpty(_activeSaveFilePath))
                return;

            if (!File.Exists(_activeSaveFilePath))
                return;

            _fileMonitor.Start(_activeSaveFilePath);

            _logger.Post(
                _activeSaveFilePath,
                "File monitoring active");
        }


        private async Task HandleSaveFileChangedAsync()
        {
            if (string.IsNullOrEmpty(_activeSaveFilePath))
                return;

            string previousDeaths = txbDeaths.Text;
            string previousLevel = txbLevel.Text;
            string previousName = txbName.Text;

            _logger.Post(
                "Change detected. Waiting 2 seconds before reading...",
                "Monitor");

            await Task.Delay(2000);

            TryOpenSaveFile();

            _logger.Post(
                "Reloading save file data...",
                "Monitor");

            _saveProfileService.ParseSaveFile(_activeSaveFilePath);

            LoadCharacters();
            RefreshActiveCharacterDisplay();

            // Preserve old death count if parsing produced
            // an invalid result.
            if (string.IsNullOrEmpty(txbDeaths.Text) ||
                txbDeaths.Text.Contains("-"))
            {
                txbDeaths.Text = previousDeaths;
            }

            // These are intentionally retained here in case
            // additional fallback behavior is added later.
            _ = previousLevel;
            _ = previousName;

            UpdateOverlay();
        }


        private void TryOpenSaveFile()
        {
            try
            {
                using (FileStream fs = new FileStream(
                    _activeSaveFilePath,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.ReadWrite))
                {
                    // Opening the file is enough to verify access.
                }
            }
            catch (Exception ex)
            {
                _logger.Post(
                    ex.Message,
                    "File Access Warning");
            }
        }


        /// <summary>
        /// Overlay show/hide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (_overlayManager.IsVisible)
            {
                _overlayManager.Hide();

                btnShowHide.Text = "Show";
                return;
            }

            _overlayManager.Show(
                txbName.Text,
                txbLevel.Text,
                txbDeaths.Text);

            btnShowHide.Text = "Hide";
        }


        private void UpdateOverlay()
        {
            _overlayManager.UpdateStats(
                txbName.Text,
                txbLevel.Text,
                txbDeaths.Text);
        }


        /// <summary>
        /// Form size and log panel
        /// </summary>

        private bool _isFormSmaller = true;

        private void btnLogShowHide_Click(object sender, EventArgs e)
        {
            Size = _isFormSmaller
                ? new Size(1329, 673)
                : new Size(343, 673);

            _isFormSmaller = !_isFormSmaller;
        }


        /// <summary>
        /// Button mouse-over highlight/colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnOverlay_MouseEnter(object sender, EventArgs e)
        {
            ControlStyleHelper.SetHover(sender, true);
        }


        private void btnOverlay_MouseLeave(object sender, EventArgs e)
        {
            ControlStyleHelper.SetHover(sender, false);
        }


        private void btnOverlay_MouseDown(
            object sender,
            MouseEventArgs e)
        {
            ControlStyleHelper.SetClick(sender, true);
        }


        private void btnOverlay_MouseUp(
            object sender,
            MouseEventArgs e)
        {
            ControlStyleHelper.SetClick(sender, false);
        }


        private void btnBrowse_MouseDown(
            object sender,
            MouseEventArgs e)
        {
            ControlStyleHelper.SetClick(sender, true);
        }


        private void btnBrowse_MouseUp(
            object sender,
            MouseEventArgs e)
        {
            ControlStyleHelper.SetClick(sender, false);
        }


        /// <summary>
        /// Textbox scrolling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txbGlobalOffset_Click(
            object sender,
            EventArgs e)
        {
            TextBoxHelper.CopyText(sender);
        }


        private void txbBlockOffset_Click(
            object sender,
            EventArgs e)
        {
            TextBoxHelper.CopyText(sender);
        }


        private void txbByteSize_Click(
            object sender,
            EventArgs e)
        {
            TextBoxHelper.CopyText(sender);
        }


        private void txbBitWidth_Click(
            object sender,
            EventArgs e)
        {
            TextBoxHelper.CopyText(sender);
        }


        private void txbDataType_Click(
            object sender,
            EventArgs e)
        {
            TextBoxHelper.CopyText(sender);
        }


        private void txbGlobalOffset_MouseDown(
            object sender,
            MouseEventArgs e)
        {
            TextBoxHelper.HideCaret(sender);
        }


        private void txbBlockOffset_MouseDown(
            object sender,
            MouseEventArgs e)
        {
            TextBoxHelper.HideCaret(sender);
        }


        private void txbByteSize_MouseDown(
            object sender,
            MouseEventArgs e)
        {
            TextBoxHelper.HideCaret(sender);
        }


        private void txbBitWidth_MouseDown(
            object sender,
            MouseEventArgs e)
        {
            TextBoxHelper.HideCaret(sender);
        }


        private void txbDataType_MouseDown(
            object sender,
            MouseEventArgs e)
        {
            TextBoxHelper.HideCaret(sender);
        }


        /// <summary>
        /// Tooltips
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void panel1_MouseClick(
            object sender,
            MouseEventArgs e)
        {
            _tooltipService.Show(
                sender,
                "Overlay floats, but only shows " +
                "when save has been updated.",
                3000);
        }


        private void panel2_MouseClick(
            object sender,
            MouseEventArgs e)
        {
            _tooltipService.Show(
                sender,
                "Overlay pops up/down vertically " +
                "when save has been updated. " +
                "Note: Only useable on top/bottom bounds.",
                3000);
        }


        private void panel3_MouseClick(
            object sender,
            MouseEventArgs e)
        {
            _tooltipService.Show(
                sender,
                "Overlay slides left/right horizontally " +
                "when save has been updated. " +
                "Note: Only useable on left/right bounds.",
                3000);
        }


        private void panel4_MouseClick(
            object sender,
            MouseEventArgs e)
        {
            _tooltipService.Show(
                sender,
                "User freely moves the overlay.",
                3000);
        }


        /// <summary>
        /// Form cleanup
        /// </summary>
        /// <param name="e"></param>

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _fileMonitor.Dispose();
            _overlayManager.Dispose();
            _tooltipService.Dispose();

            base.OnFormClosed(e);
        }
    }
}
