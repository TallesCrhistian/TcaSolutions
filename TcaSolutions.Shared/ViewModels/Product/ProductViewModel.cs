namespace TcaSolutions.Shared.ViewModels.Product
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public double? Price { get; set; }

        public double? CostPrice { get; set; }

        public int? Stock { get; set; }

        public string Supplier { get; set; }

        public DateTime ManufactureDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public string Barcode { get; set; }

        public string Image { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
