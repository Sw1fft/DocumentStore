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

        public async Task CreateDocument(Guid userId, DocumentModel document)
        {
            var model = DocumentModel.Create(
                Guid.NewGuid(),
                document.CreatedAt,
                document.DocumentName,
                ContentModel.Create(
                    Guid.NewGuid(),
                    document.Content.Title,
                    document.Content.CarName,
                    document.Content.CarModel,
                    document.Content.CarYear,
                    document.Content.CarColor,
                    document.Content.CarPrice));

            await _repository.CreateDocument(userId, model);
        }

        public async Task<List<DocumentModel>> GetDocuments(Guid userId)
        {
            return await _repository.GetDocuments(userId);
        }

        public Task<DocumentModel> UpdateDocument(Guid userId, Guid documentId, DocumentModel document)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDocument(Guid userId, Guid documentId)
        {
            throw new NotImplementedException();
        }
    }
}
