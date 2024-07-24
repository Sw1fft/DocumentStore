using DocumentStore.Domain.Models.Document;
using DocumentStore.Domain.Interfaces;
using DocumentStore.Data;

namespace DocumentStore.Application.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly DocumentStoreDbContext _dbContext;

        public DocumentRepository(DocumentStoreDbContext dbContext)
        {
            _dbContext = dbContext;
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
