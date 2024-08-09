using DocumentStore.API.DTO.Document.Request;
using DocumentStore.Domain.Models.Document;
using Microsoft.AspNetCore.Authorization;
using DocumentStore.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace DocumentStore.API.Controllers.Document
{
    [Authorize]
    [ApiController]
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
        [Route("/{userId}/get")]
        public async Task GetUserDocuments(Guid userId)
        {
            await _documentService.GetDocuments(userId);
        }

        [HttpPost]
        [Route("/{userId}/create")]
        public async Task CreateDocument([FromBody] DocumentRequestDTO documentRequest, Guid userId)
        {
            var model = _mapper.Map<DocumentRequestDTO, DocumentModel>(documentRequest);

            await _documentService.CreateDocument(userId, model);
        }

        [HttpPut]
        [Route("/{userId}/update/{documentId}")]
        public async Task UpdateDocument(Guid userId, Guid documentId, [FromBody] DocumentRequestDTO documentRequest)
        {

        }

        [HttpDelete]
        [Route("/{userId}/delete/{documentId}")]
        public async Task DeleteDocument(Guid userId, Guid documentId)
        {
            await _documentService.DeleteDocument(userId, documentId);
        }
    }
}
