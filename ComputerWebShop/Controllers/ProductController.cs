using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerWebShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult BrandItems()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }

        public ActionResult Items()
        {
            return View();
        }
    }
}