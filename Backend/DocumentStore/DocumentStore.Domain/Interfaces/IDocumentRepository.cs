using DocumentStore.Domain.Models.Document;

namespace DocumentStore.Domain.Interfaces
{
    public interface IDocumentRepository
    {
        Task CreateDocument(Guid userId, DocumentModel document);

        Task<List<DocumentModel>> GetDocuments(Guid userId);

        Task<DocumentModel> UpdateDocument(Guid userId, Guid documentId, DocumentModel document);

        Task DeleteDocument(Guid documentId);
    }
}
