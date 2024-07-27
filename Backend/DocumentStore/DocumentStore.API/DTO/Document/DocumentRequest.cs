namespace DocumentStore.API.DTO.Document
{
    public record DocumentRequest(
        DateTime CreatedAt, 
        string DocumentName,
        ContentModelDTO Content);
}
