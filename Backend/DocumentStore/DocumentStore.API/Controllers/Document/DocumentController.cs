using DocumentStore.Domain.Models.Document;
using DocumentStore.Domain.Interfaces;
using DocumentStore.API.DTO.Document;
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
        [Route("{userId:guid}")]
        public async Task GetUserDocuments(Guid userId)
        {
            await _documentService.GetDocuments(userId);
        }

        [HttpPost]
        public async Task CreateDocument([FromBody] DocumentRequest document)
        {
            var model = _mapper.Map<DocumentModel>(document);

            await _documentService.CreateDocument(Guid.NewGuid(), model);
        }

        [HttpPut]
        public async Task UpdateDocument()
        {

        }

        [HttpDelete]
        public async Task DeleteDocument()
        {

        }
    }
}
