using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace AlarmSystem.AlarmSettings
{
    public class Settings
    {
        #region Propriedades
        public string MusicPath { get; set; }
        public ThemeEnum Theme { get; set; }
        public List<string> Extensions { get; set; }
        #endregion

        public Settings()
        {
            SetExtension();
            MusicPath = GetMusicPath();
            Theme = GetTheme() == "1" ? ThemeEnum.Light : ThemeEnum.Dark;
        }

        private void SetExtension()
        {
            Extensions = new List<string>
            {
                ".aac",
                ".mp3",
                ".ogg",
                ".wma",
                ".alac",
                ".flac",
                ".aiff",
                ".pcm",
                ".wav"
            };
        }

        #region Obtém e salva configurações
        private AppSettingsSection GetAppSettings()
        {
            var map = new ExeConfigurationFileMap();
            var currentPath = Directory.GetCurrentDirectory();
            map.ExeConfigFilename = Path.Combine(currentPath, "AlarmSystem.exe.config");
            var libConfig = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            var section = libConfig.GetSection("appSettings") as AppSettingsSection;
            return section;
        }

        private void SaveSettings(string setting, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;
            settings[setting].Value = value;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
        #endregion

        #region Obtém e salva Caminho da Música
        private string GetMusicPath()
        {
            return GetAppSettings().Settings["musicPath"].Value;
        }

        public void SaveMusicPath(string musicPath)
        {
            MusicPath = musicPath;
            SaveSettings("musicPath", MusicPath);
        }

        public void SetDefaultMusicPath()
        {
            const string defaultMusicPath = @"C:\Windows\Media\Alarm05.wav";
            SaveMusicPath(defaultMusicPath);
            MusicPath = defaultMusicPath;
        }
        #endregion

        #region Obtém e salva tema
        private string GetTheme()
        {
            return GetAppSettings().Settings["theme"].Value;
        }

        public void SaveTheme(ThemeEnum theme)
        {
            const string light = "1";
            const string dark = "2";
            Theme = theme;

            var currentTheme = Theme == ThemeEnum.Light ? light : dark;
            SaveSettings("theme", currentTheme);
        }
        #endregion
    }
}
