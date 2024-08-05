using DocumentStore.API.DTO.Document.Request;
using DocumentStore.Domain.Models.Document;
using DocumentStore.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace DocumentStore.API.Controllers.Document
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        private readonly IMapper _mapper;

        public DocumentController(IDocumentService documentService, IMapper mapper)
        {
            _documentService = documentService;
            _mapper = mapper;
        }
        
        [HttpGet]
        [Route("{userId}")]
        public async Task GetUserDocuments(Guid userId)
        {
            await _documentService.GetDocuments(userId);
        }

        [HttpPost]
        public async Task CreateDocument([FromBody] DocumentRequestDTO documentRequest)
        {
            var model = _mapper.Map<DocumentRequestDTO, DocumentModel>(documentRequest);

            await _documentService.CreateDocument(Guid.NewGuid(), model); // Генерация userId выполняется для тестов
        }

        [HttpPut]
        public async Task UpdateDocument()
        {

        }

        [HttpDelete]
        [Route("{documentId}")]
        public async Task DeleteDocument(Guid documentId)
        {
            await _documentService.DeleteDocument(documentId);
        }
    }
}
