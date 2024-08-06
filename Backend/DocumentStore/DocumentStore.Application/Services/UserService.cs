using DocumentStore.Domain.Interfaces;
using DocumentStore.Domain.Models;

namespace DocumentStore.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IPasswordService _passwordService;
        private readonly IUserRepository _userRepository;

        public UserService(IPasswordService passwordService, IUserRepository userRepository)
        {
            _passwordService = passwordService;
            _userRepository = userRepository;
        }

        public Task<string> LoginUser(string login, string password)
        {


            throw new NotImplementedException();
        }

        public async Task RegisterUser(string email, string login, string password, string passwordConf)
        {
            bool passwordCheck = _passwordService.RegistrationVerify(password, passwordConf);

            if (!passwordCheck)
            {
                await Task.CompletedTask;
            }

            string passwordHashed = _passwordService.GeneratePassword(password);

            UserModel user = UserModel.Create(email, login, passwordHashed);

            await _userRepository.RegisterUser(user);
        }
    }
}
