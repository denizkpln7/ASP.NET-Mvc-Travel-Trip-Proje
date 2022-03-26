using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).ToList();
            return PartialView(degerler);
        }
    }
}