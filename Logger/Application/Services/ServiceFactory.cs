namespace Logger.Application.Services
{
    public class ServiceFactory
    {
        public LoggerTypeReader Reader;
        public LoggerWriter Writer;

        public ServiceFactory Build()
        {
            var loggerTypeReader = new LoggerTypeReader();
            var loggerWriter = new LoggerWriter();
            loggerTypeReader.TypeChangedEvent += loggerWriter.OnTypeChanged;
            Reader = loggerTypeReader;
            Writer = loggerWriter;
            return this;
        }
    }
}