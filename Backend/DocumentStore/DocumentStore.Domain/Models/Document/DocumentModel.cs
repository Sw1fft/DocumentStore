namespace DocumentStore.Domain.Models.Document
{
    public class DocumentModel
    {
        public Guid Id { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public string DocumentName { get; private set; } = null!;

        public ContentModel Content { get; private set; }

        public DocumentModel() { }

        private DocumentModel(Guid id, DateTime createdAt, string documentName, ContentModel content)
        {
            Id = id;
            CreatedAt = createdAt;
            DocumentName = documentName;
            Content = content;
        }

        public static DocumentModel Create(Guid id, DateTime createdAt, string documentName, ContentModel content)
        {
            return new DocumentModel(id, createdAt, documentName, content);
        }
    }
}
