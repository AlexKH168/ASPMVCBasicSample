using ASPMVCBasicSample.Models;
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
            //ViewBag.Address = new SelectList(AddressList()); //use with LooselyHTML
            ViewBag.AddressList = new SelectList(GetAddressList(), "ID", "Name"); //use with StronglyHTML
            return View();
        }

        public List<Address> GetAddressList()
        {
            return new List<Address>()
            {
                new Address(){ID=1,Name="Phnom Penh"},
                new Address(){ID=2,Name="Kampongchang"},
                new Address(){ID=3,Name="Pursat"},
                new Address(){ID=4,Name="Battambong"},
                new Address(){ID=5,Name="Banteaymeanchey"}
            };
        }

        public ActionResult Create()
        {
            var selectList = new SelectList(CategoryList(), "CategoryID", "CategoryName");
            ViewBag.CategoryList = selectList;

            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,Name,Price,Description,CategoryID,CategoryName")] Product product)
        {
            if (ModelState.IsValid)
            {
                var selectList = new SelectList(CategoryList(), "CategoryID", "CategoryName");
                ViewBag.CategoryList = selectList;
            }

            return View(product);
        }

        private List<Category> CategoryList()
        {
            return new List<Category>()
            {
                new Category(){CategoryID=1, CategoryName="Drink"},
                new Category(){CategoryID=2, CategoryName="Coke"},
                new Category(){CategoryID=3, CategoryName="Snake"}
            };
        }

        public List<string> AddressList()
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