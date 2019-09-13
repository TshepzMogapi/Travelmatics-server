using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Travelmatics.EntityFrameworkCore
{
    public static class TravelmaticsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TravelmaticsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TravelmaticsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
