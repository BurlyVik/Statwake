using System;
using System.IO;

namespace statwake
{
    /// <summary>
    /// Configuration fiule
    /// </summary>

    public class ConfigFile
    {
        private readonly string _configPath;

        public ConfigFile()
        {
            _configPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "config.ini");
        }

        public string SaveFilePath
        {
            get
            {
                return IniHelper.ReadValue(
                    "Settings",
                    "SaveFilePath",
                    _configPath);
            }

            set
            {
                IniHelper.WriteValue(
                    "Settings",
                    "SaveFilePath",
                    value,
                    _configPath);
            }
        }

        public string ReadSaveFilePath()
        {
            return SaveFilePath;
        }
    }
}