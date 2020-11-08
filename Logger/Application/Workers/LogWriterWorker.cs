using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Logger.Application.Workers
{
    public class LogWriterWorker : BackgroundService
    {
        private const int Delay = 5000;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(Delay, stoppingToken);
            }
        }
    }
}