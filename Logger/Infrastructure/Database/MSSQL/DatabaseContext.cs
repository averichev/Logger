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

        public DbSet<Log> Log { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Log>().HasKey(c => new {c.Time, c.Bytes});
        }
    }
}