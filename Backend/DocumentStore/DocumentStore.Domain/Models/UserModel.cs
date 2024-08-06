namespace DocumentStore.Domain.Models
{
    public class UserModel
    {
        public Guid Id { get; }

        public string UserName { get; } = null!;

        public string Email { get; } = null!;

        public string PasswordHash { get; } = null!;

        private UserModel(Guid id, string userName, string email, string passwordHash)
        {
            Id = id;
            UserName = userName;
            Email = email;
            PasswordHash = passwordHash;
        }

        public static UserModel Create(string userName, string email, string passwordHash)
        {
            return new UserModel(Guid.NewGuid(), userName, email, passwordHash);
        }
    }
}
