using System;

namespace Logger.Application.Models
{
    public interface ILog
    {
        public DateTime Time { get; set; }
        public long Bytes { get; set; }
    }
}