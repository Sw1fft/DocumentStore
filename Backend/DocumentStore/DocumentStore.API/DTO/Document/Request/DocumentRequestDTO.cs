namespace DocumentStore.API.DTO.Document.Request
{
    public record DocumentRequestDTO(
        DateTime CreatedAt,
        string DocumentName,
        ContentRequestDTO ContentRequest);
}
