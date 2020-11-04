using System.Threading;
using System.Threading.Tasks;
using Logger.Application.LoggerType;
using Logger.Application.Settings;
using Microsoft.Extensions.Hosting;

namespace Logger.Application.Workers
{
    public class LoggerTypeReaderWorker : BackgroundService
    {
        private readonly SettingsReader _settingsReader;
        private const int Delay = 10000;
        private Types Type { get; set; }
        public delegate void LoggerTypeHandler(Types type);
        public event LoggerTypeHandler Notify;     

        public LoggerTypeReaderWorker(SettingsReader settingsReader)
        {
            _settingsReader = settingsReader;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                SetType();
                await Task.Delay(Delay, stoppingToken);
            }
        }

        private void SetType()
        {
            var currentType = Type;
            var newType = TypeBuilder.Build(_settingsReader.Type());
            if (currentType == Type)
            {
                return;
            }

            Type = newType;
            Notify?.Invoke(Type);
        }
    }
}