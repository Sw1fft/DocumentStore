namespace DocumentStore.Domain.Models.Document
{
    public class ContentModel
    {
        public Guid Id { get; }

        public Guid DocumentId { get; }

        public string Title { get; } = null!;

        public string CarName { get; } = string.Empty;

        public string CarModel { get; } = string.Empty;

        public DateTime CarYear { get; }

        public string CarColor { get; } = string.Empty;

        public decimal CarPrice { get; } = 0;
    }
}
