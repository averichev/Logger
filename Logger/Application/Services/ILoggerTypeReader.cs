using System;
using Logger.Application.Models;

namespace Logger.Application.Services
{
    public interface ILoggerTypeReader
    {
        public event EventHandler<LoggerTypeChangeEventArgs> TypeChangedEvent;
        public void Read();
    }
}