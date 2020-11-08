using Logger.Application.LoggerType;
using Logger.Application.Models;

namespace Logger.Application.Services
{
    public class LoggerWriter : ILoggerWriter
    {
        private Types _loggerType;

        public void OnTypeChanged(object sender, LoggerTypeChangeEventArgs e)
        {
            _loggerType = e.Type;
        }

        public void Write(ILog log)
        {
            
        }
    }
}