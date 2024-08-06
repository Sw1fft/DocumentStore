using DocumentStore.Domain.Models.Document;
using DocumentStore.Data.Entities.Document;
using DocumentStore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using DocumentStore.Data;
using AutoMapper;

namespace DocumentStore.Application.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly DocumentStoreDbContext _dbContext;
        private readonly IMapper _mapper;

        public DocumentRepository(DocumentStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateDocument(Guid userId, DocumentModel document)
        {
            var user = _dbContext.Users
                .FirstOrDefault(u => u.Id == userId)
                ?? throw new NullReferenceException();

            var entity = new DocumentEntity
            {
                Id = document.Id,
                CreatedAt = document.CreatedAt,
                DocumentName = document.DocumentName,
                Content = new ContentEntity
                {
                    Id = document.Content.Id,
                    Title = document.Content.Title,
                    CarName = document.Content.CarName,
                    CarModel = document.Content.CarModel,
                    CarYear = document.Content.CarYear,
                    CarColor = document.Content.CarColor,
                    CarPrice = document.Content.CarPrice,
                },
                UserId = userId,
            };

            await _dbContext.Documents.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<DocumentModel>> GetDocuments(Guid userId)
        {
            var document = await _dbContext.Documents
                .Where(x => x.UserId == userId)
                .AsNoTracking()
                .ToListAsync();

            return _mapper.Map<List<DocumentModel>>(document);
        }

        public Task<DocumentModel> UpdateDocument(Guid userId, Guid documentId, DocumentModel document)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteDocument(Guid documentId)
        {
            await _dbContext.Documents
                .Where(d => d.Id == documentId)
                .ExecuteDeleteAsync();
        }
    }
}
