using System.IO;
using Logger.Application.Models;

namespace Logger.Infrastructure
{
    public class FileLogRepository : ILogRepository
    {
        private const string FilePath = "log.csv";

        public void Add(ILog log)
        {
            CheckAndCreateFile();
            WriteLineToFile(log);
        }

        private static void WriteLineToFile(ILog log)
        {
            using var sw = File.AppendText(FilePath);
            sw.WriteLine(log.Time + ";" + log.Bytes);
        }

        private static void CheckAndCreateFile()
        {
            var exist = File.Exists(FilePath);
            if (!exist)
            {
                File.Create(FilePath).Dispose();
            }
        }
    }
}