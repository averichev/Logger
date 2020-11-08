using IniParser;
using IniParser.Model;

namespace Logger.Application.Settings
{
    public sealed class SettingsReader
    {
        private readonly KeyDataCollection _settings;
        
        public SettingsReader(KeyDataCollection settings)
        {
            _settings = settings;
        }

        public string Type()
        {
            var data = _settings.GetKeyData("LoggerType");
            var type = data.Value.Trim('"');
            return type;
        }
        public string ConnectionString()
        {
            return _settings.GetKeyData("ConnectionString").Value;
        }
    }
}