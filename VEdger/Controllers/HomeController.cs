using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VEdger.Models;
using VEdger.Repository;

namespace VEdger.Controllers
{
    public class HomeController : Controller
    {

          // Przykład wykorzystania 
        //readonly IRepository<UserData> repository = new EntityRepository<UserData>();
        //
        //public ActionResult Index()
        //
        //{
        //    var data = repository.Read<UserData>();       
        //    return View(data);       
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
    }
}