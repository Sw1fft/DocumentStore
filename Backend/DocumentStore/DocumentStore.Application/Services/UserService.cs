using DocumentStore.Domain.Interfaces;
using DocumentStore.Domain.Models;

namespace DocumentStore.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IPasswordService _passwordService;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;

        public UserService(IPasswordService passwordService, IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _passwordService = passwordService;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
        }

        public async Task<string> LoginUser(string email, string password)
        {
            UserModel user = await _userRepository.GetUserByEmail(email);

            bool isValid = _passwordService.VerifyPassword(password, user.PasswordHash);

            if (!isValid)
            {
                throw new Exception("Incorrect data");
            }

            string token = _jwtProvider.GenerateToken(user);

            return token;
        }

        public async Task RegisterUser(string email, string userName, string password, string passwordConf)
        {
            bool passwordCheck = _passwordService.RegistrationVerify(password, passwordConf);

            if (!passwordCheck)
            {
                await Task.CompletedTask;
            }

            string passwordHashed = _passwordService.GeneratePassword(password);

            UserModel user = UserModel.Create(userName, email, passwordHashed);

            await _userRepository.RegisterUser(user);
        }
    }
}
