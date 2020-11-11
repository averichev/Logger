using Logger.Application.LoggerType;
using Logger.Application.Models;
using Logger.Infrastructure.Database.MSSQL;

namespace Logger.Infrastructure
{
    public static class RepositoryWriterSelector
    {
        public static ILogRepository Select(Types type)
        {
            ILogRepository repository = type switch
            {
                Types.Database => new DbLogRepository(),
                _ => new FileLogRepository()
            };

            return repository;
        }
    }
}