using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace s4_l4
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal VendorCode { get; set; }
        public decimal Price { get; set; }
        protected Product(string name, decimal vendorCode, decimal price)
        {
            Name = name;
            VendorCode = vendorCode;
            this.Price = price;
        }
    }
}