using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ikub2.Models;

namespace Ikub2.Controllers
{
    public class ProductController : Controller
    {
        List<Product> produktet = new List<Product>()
        {
          new Product{id=1, name="Prod1", price=14},
          new Product{id=2, name="Prod2", price=12}
        };

        public ActionResult ProductList()
        {
            return View(produktet);
        }

        public ActionResult Details(int id)
        {
          Product p = produktet.Find(a=>a.id.Equals(id));
          return View(p);
        }
       public ActionResult ProductsPartial()
        {
          ViewBag.List = new List<Product>()
              {
                new Product{id=1, name="Prod1" },
                new Product{id=2, name="Prod2"}
              };
          return View();
        }

    }
}