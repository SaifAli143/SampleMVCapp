using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMVCapp.Models;


namespace SampleMVCapp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Productlist()
        {
            List<Product> Productlist = new List<Product>()
            {
                new Product{Id=1,Name ="laptop",Company="Dell",Price=35500 },
                new Product{Id=1,Name ="laptop",Company="Lenovo",Price=38500 },
                new Product{Id=1,Name ="Key board",Company="Dell",Price=500 },
                new Product{Id=1,Name ="mouse",Company="Dell",Price=400 },

            };
            ViewBag.ProductList = Productlist;
            return View();
        }

        public ActionResult Save()                 
        {
            return View();
        }
    }
}