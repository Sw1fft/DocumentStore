namespace DocumentStore.Domain.Models.Document
{
    public class ContentModel
    {
        public Guid Id { get; }

        public string Title { get; } = null!;

        public string CarName { get; } = string.Empty;

        public string CarModel { get; } = string.Empty;

        public DateTime CarYear { get; }

        public string CarColor { get; } = string.Empty;

        public decimal CarPrice { get; } = 0;

        private ContentModel(
            Guid id, 
            string title, 
            string carName,
            string carModel, 
            DateTime carYear, 
            string carColor, 
            decimal carPrice)
        {
            Id = id;
            Title = title;
            CarName = carName;
            CarModel = carModel;
            CarYear = carYear;
            CarColor = carColor;
            CarPrice = carPrice;
        }

        public static ContentModel Create(
            Guid id,
            string title,
            string carName,
            string carModel,
            DateTime carYear,
            string carColor,
            decimal carPrice)
        {
            return new ContentModel(id, title, carName, carModel, carYear, carColor, carPrice);
        }
    }
}
