using System.Threading;
using System.Threading.Tasks;
using Logger.Application.Services;
using Microsoft.Extensions.Hosting;

namespace Logger.Application.Workers
{
    public class LoggerTypeReaderWorker : BackgroundService
    {
        private const int Delay = 10000;
        private readonly ILoggerTypeReader _reader;

        public LoggerTypeReaderWorker(ILoggerTypeReader reader)
        {
            _reader = reader;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _reader.Read();
                await Task.Delay(Delay, stoppingToken);
            }
        }
    }
}