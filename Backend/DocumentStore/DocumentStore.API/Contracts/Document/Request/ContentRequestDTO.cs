namespace DocumentStore.API.DTO.Document.Request
{
    public record ContentRequestDTO(
        string Title,
        string CarName,
        string CarModel,
        DateTime CarYear,
        string CarColor,
        decimal CarPrice);
}
