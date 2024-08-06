namespace DocumentStore.Domain.Interfaces
{
    public interface IUserService
    {
        Task<string> LoginUser(string login, string password);

        Task RegisterUser(string email, string login, string password, string passwordConf);
    }
}
