using IniParser;

namespace Logger.Application.Settings
{
    public static class IniFileReader
    {
        public static SettingsReader Read()
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile("LoggerServiceConfiguration.ini");
            var result = data.Sections["Logger"];
            return new SettingsReader(result);
        }
    }
}