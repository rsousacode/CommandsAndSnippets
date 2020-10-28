using UsersServer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UsersServer.Data.Identities
{
    public sealed class UserDbContext : IdentityDbContext<User>
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public override DbSet<User> Users { get; set; }

        //public override DbSet<TUserRole> UserRoles { get; set; }
          
        //public override DbSet<TRole> Roles { get; set; }

        //public override DbSet<TRoleClaim> RoleClaims { get; set; }

        /// <summary>
        /// Configures the schema needed for the identity framework.
        /// </summary>
        /// <param name="builder">
        /// The builder being used to construct the model for this context.
        /// </param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}