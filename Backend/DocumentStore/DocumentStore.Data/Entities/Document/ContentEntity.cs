namespace DocumentStore.Data.Entities.Document
{
    public class ContentEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;

        public string CarName { get; set; } = string.Empty;

        public string CarModel { get; set; } = string.Empty;

        public DateTime CarYear { get; set; }

        public string CarColor { get; set; } = string.Empty;

        public decimal CarPrice { get; set; } = 0;

        public Guid DocumentId { get; set; }
        public DocumentEntity Document { get; set; } = null!;
    }
}
