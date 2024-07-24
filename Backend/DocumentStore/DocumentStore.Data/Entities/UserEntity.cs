using DocumentStore.Data.Entities.Document;

namespace DocumentStore.Data.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }

        public string UserName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public List<DocumentEntity> Documents { get; set; } = [];
    }
}
