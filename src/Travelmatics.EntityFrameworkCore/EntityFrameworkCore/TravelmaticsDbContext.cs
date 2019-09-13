using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Travelmatics.Authorization.Roles;
using Travelmatics.Authorization.Users;
using Travelmatics.MultiTenancy;

namespace Travelmatics.EntityFrameworkCore
{
    public class TravelmaticsDbContext : AbpZeroDbContext<Tenant, Role, User, TravelmaticsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TravelmaticsDbContext(DbContextOptions<TravelmaticsDbContext> options)
            : base(options)
        {
        }
    }
}
