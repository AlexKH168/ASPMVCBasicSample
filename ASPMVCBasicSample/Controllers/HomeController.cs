using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVCBasicSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Address = new SelectList(GenderList());
            return View();
        }

        public List<string> GenderList()
        {
            return new List<string>()
            {
                "Phnom Penh",
                "Kampungchang",
                "Pursat",
                "Battambong",
                "Banteaymeanchey"
            };
        }
    }
}