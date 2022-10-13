using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;


namespace WebAPI.Services
{
    public class OfferService 
    {
        private List<Product> Inventory { get; set; }

        private List<Product> createinventory()
        {
            var products = new List<Product>();
            products.Add(new Product("P1", 1000, "P1 desc"));
            products.Add(new Product("P2", 200, "P2 desc"));
            products.Add(new Product("P3", 400, "P3 desc"));
            products.Add(new Product("P4", 700, "P4 desc"));
            products.Add(new Product("P5", 600, "P5 desc"));
            products.Add(new Product("P6", 800, "P6 desc"));
            return products;
        }

        public OfferService()
        {
            this.Inventory = createinventory();
        }

        public List<Product> GetAllProducts()
        {
            return this.Inventory;
        }

        public List <Offer> GetTodaysOffers()
        {
            var offers = new List<Offer>();

            offers.Add(new Offer("ComboPackage1", this.Inventory.GetRange(0, 3)));
            offers.Add(new Offer("ComboPackage2", this.Inventory.GetRange(1, 3)));
            offers.Add(new Offer("ComboPackage3", this.Inventory.GetRange(2, 3)));
            offers.Add(new Offer("ComboPackage4", this.Inventory.GetRange(3, 3)));

            return offers;
        }
    }
}