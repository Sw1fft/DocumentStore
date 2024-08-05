namespace DocumentStore.Domain.Models.Document
{
    public class DocumentModel
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string DocumentName { get; set; } = null!;

        public ContentModel Content { get; set; }

        private DocumentModel(Guid id, DateTime createdAt, string documentName, ContentModel content)
        {
            Id = id;
            CreatedAt = createdAt;
            DocumentName = documentName;
            Content = content;
        }

        public static DocumentModel Create(DateTime createdAt, string documentName, ContentModel content)
        {
            return new DocumentModel(Guid.NewGuid(), createdAt, documentName, content);
        }
    }
}
