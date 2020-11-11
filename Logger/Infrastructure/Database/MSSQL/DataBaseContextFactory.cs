using Microsoft.EntityFrameworkCore;

namespace Logger.Infrastructure.Database.MSSQL
{
    public static class DataBaseContextFactory
    {
        public static DataBaseContext CreateDbContext(string connectionString)
        {
            var builder = new DbContextOptionsBuilder<DataBaseContext>();
            builder.UseSqlServer(connectionString);
            return new DataBaseContext(builder.Options);
        }
    }
}