using DocumentStore.Domain.Models.Document;

namespace DocumentStore.API.DTO.Document
{
    public record DocumentRequest(
        DateTime CreatedAt, 
        string DocumentName,
        List<ContentDto> Content);
}
