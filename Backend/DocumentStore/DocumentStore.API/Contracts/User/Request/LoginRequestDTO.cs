using System.ComponentModel.DataAnnotations;

namespace DocumentStore.API.DTO.User.Request
{
    public record LoginRequestDTO(
        [Required] string Email,
        [Required] string Password);
}
