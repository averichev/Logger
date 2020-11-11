using Logger.Application.LoggerType;
using Logger.Application.Models;
using Logger.Infrastructure;

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
            var repository = RepositoryWriterSelector.Select(_loggerType);
            repository.Add(log);
        }
    }
}