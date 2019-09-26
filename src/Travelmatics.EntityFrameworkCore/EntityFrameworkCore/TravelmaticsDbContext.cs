using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Travelmatics.Authorization.Roles;
using Travelmatics.Authorization.Users;
using Travelmatics.MultiTenancy;
using Travelmatics.Contacts;

namespace Travelmatics.EntityFrameworkCore
{
    public class TravelmaticsDbContext : AbpZeroDbContext<Tenant, Role, User, TravelmaticsDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public virtual DbSet<Contact> Contacts { get; set; }

        //public virtual DbSet<ContactDetail> ContactDetails { get; set; }


        public TravelmaticsDbContext(DbContextOptions<TravelmaticsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<UserContact>()
            //    .HasKey(uc => new { uc.UserId, uc.ContactId });

            //modelBuilder.Entity<UserContact>()
            //   .HasOne(uc => uc.User)
            //   .HasForeignKey(ua => ua.UserId);

          
        }
    }
}
