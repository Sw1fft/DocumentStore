using DocumentStore.Data.Configurations.Document;
using DocumentStore.Data.Entities.Document;
using DocumentStore.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using DocumentStore.Data.Entities;

namespace DocumentStore.Data
{
    public class DocumentStoreDbContext : DbContext
    {
        public DocumentStoreDbContext(DbContextOptions<DocumentStoreDbContext> options) 
            : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<DocumentEntity> Documents { get; set; }
        public DbSet<ContentEntity> Contents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentConfiguration());
            modelBuilder.ApplyConfiguration(new ContentConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
