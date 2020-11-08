using Logger.Application.Services;
using Logger.Application.Workers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Logger
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                    {
                        var loggerTypeReader = new LoggerTypeReader();
                        var loggerWriter = new LoggerWriter();
                        loggerTypeReader.TypeChangedEvent += loggerWriter.OnTypeChanged;
                        services.AddSingleton<ILoggerTypeReader>(loggerTypeReader);
                        services.AddSingleton<ILoggerWriter>(loggerWriter);
                        services.AddHostedService<LoggerTypeReaderWorker>();
                        services.AddHostedService<LogWriterWorker>();
                    }
                );
        }
    }
}