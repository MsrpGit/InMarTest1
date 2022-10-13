using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product(string Productname, decimal Price, string Description)
        {
            this.ProductName = Productname;
            this.Price = Price;
            this.Description = Description;
        }
    }
}