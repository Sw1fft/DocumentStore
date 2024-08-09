namespace DocumentStore.API.DTO.User.Request
{
    public record LoginRequestDTO(
        string Email,
        string Password);
}
