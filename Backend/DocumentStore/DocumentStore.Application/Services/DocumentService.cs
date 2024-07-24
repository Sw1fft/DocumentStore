using DocumentStore.Domain.Models.Document;
using DocumentStore.Domain.Interfaces;

namespace DocumentStore.Application.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository _repository;

        public DocumentService(IDocumentRepository repository)
        {
            _repository = repository;
        }

        public Task CreateDocument(Guid userId, DocumentModel document)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDocument(Guid userId, Guid documentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<DocumentModel>> GetDocuments(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<DocumentModel> UpdateDocument(Guid userId, Guid documentId, DocumentModel document)
        {
            throw new NotImplementedException();
        }
    }
}
