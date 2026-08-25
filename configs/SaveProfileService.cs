using edcs_edlen_death_counter_service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace statwake
{
    // Profile management
    public class SaveProfileService
    {
        private readonly LogService _logger;

        public SaveProfileService(LogService logger)
        {
            _logger = logger;
        }

        public string JsonPath
        {
            get
            {
                return Path.Combine(
                    AppContext.BaseDirectory,
                    "profiles.json");
            }
        }

        public void ParseSaveFile(string saveFilePath)
        {
            if (!File.Exists(saveFilePath))
            {
                _logger.Post(
                    saveFilePath,
                    "Save file not found");

                return;
            }

            try
            {
                _logger.Post(
                    saveFilePath,
                    "Beginning save file parse");

                EldenRingSaveParser parser =
                    new EldenRingSaveParser();

                List<SaveProfile> profiles =
                    parser.ExtractProfiles(saveFilePath);

                string json =
                    JsonConvert.SerializeObject(
                        profiles,
                        Formatting.Indented);

                File.WriteAllText(
                    JsonPath,
                    json);

                _logger.Post(
                    JsonPath,
                    "Profiles exported to JSON");
            }
            catch (Exception ex)
            {
                _logger.Post(
                    ex.Message,
                    "ERROR");
            }
        }
    }
}
