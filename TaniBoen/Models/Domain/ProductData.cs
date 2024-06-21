namespace TaniBoen.Models.Domain
{
    public class ProductData
    {
        public Guid Id { get; set; }

        public string ProductName { get; set; }

        public int ProductRating { get; set; }

        public int ProductTotalReview { get; set; }

        public int ProductSold { get; set; }

        public decimal ProductPrice { get; set; }

        public int ProductQuantity { get; set; }

    }
}
