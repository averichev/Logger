using System;
using Logger.Application.LoggerType;
using Logger.Application.Models;
using Logger.Application.Settings;

namespace Logger.Application.Services
{
    public class LoggerTypeReader : ILoggerTypeReader
    {
        public event EventHandler<LoggerTypeChangeEventArgs> TypeChangedEvent;
        private Types Type { get; set; }

        public void Read()
        {
            SetType();
        }

        private void SetType()
        {
            var readType = IniFileReader.Read().Type();
            var newType = TypeBuilder.Build(readType);
            if (Type == newType)
            {
                return;
            }

            Type = newType;
            Console.WriteLine("Invoke!!");
            TypeChangedEvent?.Invoke(this, new LoggerTypeChangeEventArgs(newType));
        }
        
    }
}