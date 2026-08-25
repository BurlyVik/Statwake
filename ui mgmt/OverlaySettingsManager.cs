using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace statwake
{
    /// <summary>
    ///  Overla
    /// </summary>
    public static class OverlaySettingsManager
    {
        public static string GetConfigPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");
        }

        public static void LoadOverlayColors(params Control[] controls)
        {
            string iniPath = GetConfigPath();

            foreach (var ctrl in controls)
            {
                if (ctrl != null)
                {
                    string colorValue = IniHelper.ReadValue("Colors", ctrl.Name, iniPath);
                    ApplyColorIfExists(ctrl, colorValue);
                }
            }
        }

        public static void SaveLabelColor(Control ctrl)
        {
            if (ctrl != null)
            {
                IniHelper.WriteValue("Colors", ctrl.Name, ctrl.ForeColor.ToArgb().ToString(), GetConfigPath());
            }
        }

        private static void ApplyColorIfExists(Control ctrl, string argbStr)
        {
            if (!string.IsNullOrEmpty(argbStr) && int.TryParse(argbStr, out int argb))
            {
                ctrl.ForeColor = Color.FromArgb(argb);
            }
        }
    }
}