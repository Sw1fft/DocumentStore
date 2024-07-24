using Microsoft.AspNetCore.Mvc;

namespace DocumentStore.API.Controllers.Document
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        [HttpGet]
        public async Task GetUserDocuments()
        {

        }

        [HttpPost]
        public async Task CreateDocument()
        {

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
