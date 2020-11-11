using System;
using Logger.Application.Models;
using Logger.Application.Settings;
using Log = Logger.Infrastructure.Models.Log;

namespace Logger.Infrastructure.Database.MSSQL
{
    public class DbLogRepository : ILogRepository
    {
        private readonly DataBaseContext _context;
        public DbLogRepository()
        {
            var connectionString = IniFileReader.Read().ConnectionString();
            _context = DataBaseContextFactory.CreateDbContext(connectionString);
        }

        public void Add(ILog log)
        {
            var entity = new Log(log.Time, log.Bytes);
            _context.Set<Log>().Add(entity);
            var save = _context.SaveChanges();
            Console.WriteLine(save);
        }
    }
}