﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14WpfApp
{
    public enum ProductCategorys
    {
        Food,
        Appliances
    }

    public class Product
    {
        public string ProdName { get; set; }
        public decimal Price { get; set; }
        public string ProdImage { get; set; }
        public ProductCategorys ProductCategory { get; set; }

    }
}
