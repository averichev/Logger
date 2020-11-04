using System;

namespace Logger.Infrastructure.Models
{
    public class Log
    {
        public DateTime Time { get; set; }
        public long Bytes { get; set; }
    }
}