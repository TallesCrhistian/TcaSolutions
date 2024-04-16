﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcaSolutions.Shared.ViewModels.Product
{
    public class ProductListViewModel
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Category { get; set; }

        public string? Barcode { get; set; }

        public int? Stock { get; set; }
    }
}
