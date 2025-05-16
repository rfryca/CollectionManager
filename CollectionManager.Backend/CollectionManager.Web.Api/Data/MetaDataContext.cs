using Microsoft.EntityFrameworkCore;

namespace CollectionManager.Web.Api.Data
{
    public class MetaDataContext : DbContext
    {
        public MetaDataContext(DbContextOptions<MetaDataContext> options) : base(options)
        {
        }
        //public DbSet<Entities.Metadata.ItemType> ItemTypes { get; set; } = null!;
        public DbSet<Entities.Metadata.CollectionType> CollectionTypes { get; set; } = null!;
        public DbSet<Entities.Metadata.CategoryType> CategoryTypes { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Entities.Metadata.ItemType>().ToTable("ItemTypes");
            modelBuilder.Entity<Entities.Metadata.CollectionType>().ToTable("CollectionTypes");
            modelBuilder.Entity<Entities.Metadata.CategoryType>().ToTable("CategoryTypes");
        }
    }
   
}
