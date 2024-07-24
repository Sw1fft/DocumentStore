using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DocumentStore.Data.Entities.Document;
using Microsoft.EntityFrameworkCore;

namespace DocumentStore.Data.Configurations.Document
{
    public class ContentConfiguration : IEntityTypeConfiguration<ContentEntity>
    {
        public void Configure(EntityTypeBuilder<ContentEntity> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .HasOne(c => c.Document)
                .WithOne(d => d.Content);
        }
    }
}
