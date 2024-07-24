namespace DocumentStore.Data.Entities.Document
{
    public class DocumentEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string DocumentName { get; set; } = null!;

        public ContentEntity Content { get; set; } = new ContentEntity();

        public Guid UserId { get; set; }
        public UserEntity User { get; set; } = null!;
    }
}
