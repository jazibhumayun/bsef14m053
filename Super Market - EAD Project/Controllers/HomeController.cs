using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Super_Market___EAD_Project.Controllers
{
    public class HomeController : Controller
    {
        private SuperMarketDBEntities db = new SuperMarketDBEntities();
        //public ActionResult ListUsers()
        //{
        //    IEnumerable<UserSupermarket> users = db.UserSupermarket.ToList();
        //    return View(users);
        //}
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Groceries()
        {
            return View();
        }
        public ActionResult Household()
        {
            return View();
        }
        public ActionResult Personalcare()
        {
            return View();
        }
        public ActionResult Packagedfoods()
        {
            return View();
        }
        public ActionResult Beverages()
        {
            return View();
        }
        public ActionResult Gourmet()
        {
            return View();
        }
        public ActionResult Offers()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        public ActionResult Registered()
        {
            return View();
        }
        public ActionResult Short_codes()
        {
            return View();
        }
        public ActionResult Single()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
    }
}