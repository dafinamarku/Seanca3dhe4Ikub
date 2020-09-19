using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ikub2.Models;

namespace Ikub2.Controllers
{
    public class CategoryController : Controller
    {
    
    
        public ActionResult CategoryListPartial()
        {
          ViewBag.List = new List<Category>()
          {
            new Category{id=1, name="Veshje" },
            new Category{id=2, name="Ushqime"}
          };

          return View();
        }
    }
}