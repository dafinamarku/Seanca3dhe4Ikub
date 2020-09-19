using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ikub2.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index(string s) 
    {
      return View();
    }

    public ActionResult About()
    {
      return Content("About content here", "text/plain");
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}