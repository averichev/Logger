using System;
using System.Threading;
using System.Threading.Tasks;
using Logger.Application.LoggerType;
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

        private static void Handler(Types type)
        {
            Console.WriteLine("Handler !!!!!");
            Console.WriteLine(type);
        }
    }
}