namespace TcaSolutions.Shared.DTOs
{
    public class ProductDTO : EnitityBaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal CostPrice { get; set; }
        public int Stock { get; set; }
        public string Supplier { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Barcode { get; set; }
        public string Image { get; set; }
    }
}
