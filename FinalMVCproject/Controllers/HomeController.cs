using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalMVCproject.Models;

namespace FinalMVCproject.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Requirements()
        {
            return View();
        }
        public ActionResult Countries()
        {
            return View();
        }
        public ActionResult Taxi_Vs_UberDriver()
        {
            return View();
        }
        //[HttpGet]
        //public ActionResult myregistration(int id=0)
        //{
        //    tblUserProfile user = new tblUserProfile();
        //    return View(user);
        //}
        //[HttpPost]
        //public ActionResult myregistration(tblUserProfile user)
        //{
        //    using (uber_dbEntities dbmodel = new uber_dbEntities())
        //    {

        //        dbmodel.tblUserProfiles.Add(user);
        //        dbmodel.SaveChanges();
                    
        //    }
        //    ModelState.Clear();
        //    ViewBag.Message = "Add succesfully";
        //        return View("myregistration",new tblUserProfile());
        //}

        [HttpGet]
        public ActionResult registrationform(int id = 0)
        {
            tblUserProfile user = new tblUserProfile();
            return View(user);
        }
        [HttpPost]
        public ActionResult registrationform(tblUserProfile user)
        {
            using (uber_dbEntities3 dbmodel = new uber_dbEntities3())
            {

                dbmodel.tblUserProfiles.Add(user);
                dbmodel.SaveChanges();

            }
            ModelState.Clear();
            ViewBag.Message = "Add succesfully";
            return View("myregistration", new tblUserProfile());
        }
    }

}