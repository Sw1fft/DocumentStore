using System.ComponentModel.DataAnnotations;

namespace DocumentStore.API.DTO.User.Request
{
    public record RegisterRequestDTO(
        [Required] string Email,
        [Required] string Login,
        [Required] string Password,
        [Required] string PasswordConf);
}
