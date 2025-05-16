using CollectionManager.Web.Api.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CollectionManager.Web.Api.Data
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        private readonly DbContextOptions<IdentityDataContext> options;

        public IdentityDataContext(DbContextOptions<IdentityDataContext> options ) : base(options)
        {
            this.options = options;
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }   
   
}
