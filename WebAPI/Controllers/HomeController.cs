using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {

        private OfferService _OfferServie = new OfferService();

        //public HomeController(OfferService offserveice)
        //{
        //    this._OfferServie = new OfferService();
        //}

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            var filterdProducts = this._OfferServie.GetAllProducts().OrderBy(s => s.Price).ToList().Take(3);
            return filterdProducts.ToList();

        }

        [HttpGet()]
        public IEnumerable<Product> GetAllProducts2ndLowest()
        {
            var filterdProducts = this._OfferServie.GetAllProducts().OrderBy(s => s.Price).ToList().Take(2).Reverse().Take(1);
            return filterdProducts.ToList();

        }

        [HttpGet]
        public IEnumerable<Offer> GetTodaysOffers()
        {
            var offers = this._OfferServie.GetTodaysOffers().ToList();
            return offers;
        }
    }
}
