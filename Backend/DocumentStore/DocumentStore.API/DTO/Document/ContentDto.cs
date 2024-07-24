namespace DocumentStore.API.DTO.Document
{
    public record ContentDto(
        string Title,
        string CarName,
        string CarModel,
        DateTime CarYear,
        string CarColor,
        decimal CarPrice);
}
