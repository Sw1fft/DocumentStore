namespace DocumentStore.API.DTO.Document.Request
{
    public class DocumentDTO
    {
        public string DocumentName { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public class ContentDTO
    {
        public string Title { get; } = null!;

        public string CarName { get; } = string.Empty;

        public string CarModel { get; } = string.Empty;

        public DateTime CarYear { get; }

        public string CarColor { get; } = string.Empty;

        public decimal CarPrice { get; } = 0;
    }
}
