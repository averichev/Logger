using IniParser;
using IniParser.Model;

namespace Logger.Application.Settings
{
    public sealed class SettingsReader
    {
        private readonly KeyDataCollection _settings;
        
        public SettingsReader()
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile("LoggerServiceConfiguration.ini");
            _settings = data.Sections["Logger"];
        }

        public string Type()
        {
            return _settings.GetKeyData("LoggerType").Value;
        }
        public string ConnectionString()
        {
            return _settings.GetKeyData("ConnectionString").Value;
        }
    }
}