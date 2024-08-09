using DocumentStore.Domain.Interfaces;

namespace DocumentStore.Application.Services
{
    public class PasswordService : IPasswordService
    {
        public string GeneratePassword(string password)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(password);
        }

        public bool RegistrationVerify(string password, string passwordConf)
        {
            if (passwordConf != password)
            {
                return false;
            }

            return true;
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, hashedPassword);
        }
    }
}
