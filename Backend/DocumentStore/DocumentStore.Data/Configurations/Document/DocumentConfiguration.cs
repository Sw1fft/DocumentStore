using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DocumentStore.Data.Entities.Document;
using Microsoft.EntityFrameworkCore;

namespace DocumentStore.Data.Configurations.Document
{
    public class DocumentConfiguration : IEntityTypeConfiguration<DocumentEntity>
    {
        public void Configure(EntityTypeBuilder<DocumentEntity> builder)
        {
            builder.HasKey(d => d.Id);

            builder
                .HasOne(d => d.Content)
                .WithOne(c => c.Document)
                .HasForeignKey<ContentEntity>(c => c.DocumentId);
        }
    }
}
