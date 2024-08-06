using DocumentStore.Domain.Models;

namespace DocumentStore.Domain.Interfaces
{
    public interface IJwtProvider
    {
        string GenerateToken(UserModel user);
    }
}
