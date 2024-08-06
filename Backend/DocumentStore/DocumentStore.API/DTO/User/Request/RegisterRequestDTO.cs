namespace DocumentStore.API.DTO.User.Request
{
    public record RegisterRequestDTO(
        string Email,
        string Login,
        string Password,
        string PasswordConf);
}
