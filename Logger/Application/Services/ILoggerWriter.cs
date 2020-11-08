using Logger.Application.Models;

namespace Logger.Application.Services
{
    public interface ILoggerWriter
    {
        public void OnTypeChanged(object sender, LoggerTypeChangeEventArgs e);
        public void Write(ILog log);
    }
}