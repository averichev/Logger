using System;

namespace Logger.Infrastructure.Models
{
    public class Log
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