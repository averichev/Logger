using Logger.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Logger.Infrastructure.Database.MSSQL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Log> Logs { get; set; }
    }
}