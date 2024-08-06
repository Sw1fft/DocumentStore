using DocumentStore.Domain.Interfaces;

namespace DocumentStore.Application.Services
{
    public class PasswordService : IPasswordService
    {
        public string GeneratePassword(string password)
        {
            throw new NotImplementedException();
        }

        public bool RegistrationVerify(string password, string passwordConf)
        {
            throw new NotImplementedException();
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            throw new NotImplementedException();
        }
    }
}
