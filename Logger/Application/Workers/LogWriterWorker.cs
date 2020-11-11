using System;
using System.Threading;
using System.Threading.Tasks;
using Logger.Application.Memory;
using Logger.Application.Models;
using Logger.Application.Services;
using Microsoft.Extensions.Hosting;

namespace Logger.Application.Workers
{
    public class LogWriterWorker : BackgroundService
    {
        private readonly ILoggerWriter _writer;
        private const int Delay = 5000;

        public LogWriterWorker(ILoggerWriter writer)
        {
            _writer = writer;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var memory = MemoryGetter.GetBytes();
                var time = DateTime.Now;
                var log = new Log(time, memory);
                _writer.Write(log);
                await Task.Delay(Delay, stoppingToken);
            }
        }
    }
}