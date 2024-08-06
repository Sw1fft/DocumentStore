using DocumentStore.Domain.Models;

namespace DocumentStore.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task RegisterUser(UserModel user);

        Task<UserModel> GetUserById(Guid userId);

        Task<UserModel> GetUserByEmail(string email);
    }
}
