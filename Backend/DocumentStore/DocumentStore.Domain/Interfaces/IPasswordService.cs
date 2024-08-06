namespace DocumentStore.Domain.Interfaces
{
    public interface IPasswordService
    {
        string GeneratePassword(string password);

        bool VerifyPassword(string password, string hashedPassword);

        bool RegistrationVerify(string password, string passwordConf);
    }
}
