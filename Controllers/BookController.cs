using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleMVCapp.Models;
using System.Web.Mvc;

namespace SampleMVCapp.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBook(Book Book)
        {
            return View();
        }
    }
}