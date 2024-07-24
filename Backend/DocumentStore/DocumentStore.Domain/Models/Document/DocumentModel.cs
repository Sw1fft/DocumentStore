namespace DocumentStore.Domain.Models.Document
{
    public class DocumentModel
    {
        public Guid Id { get; }

        public DateTime CreatedAt { get; }

        public string DocumentName { get; } = null!;

        public List<ContentModel> Content { get; } = [];
    }
}
