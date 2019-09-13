using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Travelmatics.Configuration;
using Travelmatics.Web;

namespace Travelmatics.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TravelmaticsDbContextFactory : IDesignTimeDbContextFactory<TravelmaticsDbContext>
    {
        public TravelmaticsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TravelmaticsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TravelmaticsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TravelmaticsConsts.ConnectionStringName));

            return new TravelmaticsDbContext(builder.Options);
        }
    }
}
