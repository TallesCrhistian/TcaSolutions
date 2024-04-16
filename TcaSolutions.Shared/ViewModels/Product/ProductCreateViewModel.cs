using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcaSolutions.Shared.ViewModels.Product
{
    public class ProductCreateViewModel
    {
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
