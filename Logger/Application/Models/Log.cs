using System;

namespace Logger.Application.Models
{
    public class Log : ILog
    {
        public Log(DateTime time, long bytes)
        {
            Time = time;
            Bytes = bytes;
        }

        public DateTime Time { get; set; }
        public long Bytes { get; set; }
    }
}