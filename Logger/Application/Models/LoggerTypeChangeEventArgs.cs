using System;
using Logger.Application.LoggerType;

namespace Logger.Application.Models
{
    public class LoggerTypeChangeEventArgs : EventArgs
    {
        public readonly Types Type;
        public LoggerTypeChangeEventArgs(Types type)
        {
            Type = type;
        }
    }
}