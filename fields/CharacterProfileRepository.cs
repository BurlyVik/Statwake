using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace statwake
{
    /// <summary>
    /// Character profile repository
    /// </summary>

    public class CharacterProfileRepository
    {
        private readonly LogService _logger;

        public List<CharacterProfile> Characters { get; private set; }
            = new List<CharacterProfile>();

        public CharacterProfileRepository(
            LogService logger)
        {
            _logger = logger;
        }

        private string JsonPath
        {
            get
            {
                return Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "profiles.json");
            }
        }

        public void Load()
        {
            if (!File.Exists(JsonPath))
            {
                _logger.Post(
                    JsonPath,
                    "JSON profiles file missing");

                Characters.Clear();

                return;
            }

            try
            {
                string jsonContent =
                    File.ReadAllText(JsonPath);

                List<CharacterProfile> characters =
                    JsonConvert.DeserializeObject<
                        List<CharacterProfile>>(jsonContent)
                    ?? new List<CharacterProfile>();

                _logger.Post(
                    $"Deserialized {characters.Count} characters from JSON.",
                    "Debug");

                Characters.Clear();

                foreach (CharacterProfile character in characters)
                {
                    if (character.IsActive &&
                        character.Name != null)
                    {
                        Characters.Add(character);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Post(
                    ex.Message,
                    "Character Load ERROR");

                Characters.Clear();
            }
        }

        public CharacterProfile FindBySlot(
            object targetSlot)
        {
            foreach (CharacterProfile character in Characters)
            {
                if (character.SlotIndex.Equals(targetSlot))
                    return character;
            }

            return null;
        }
    }
}
