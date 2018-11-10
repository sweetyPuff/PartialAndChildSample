using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace PartialAndChild.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ForIndexChildAction()
        {

            ViewData.Model = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ffff");
            return View();
        }


        public ActionResult ForIndexAjax()
        {
            //Thread.Sleep(3000);
            ViewData.Model = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ffff");
            return View();
        }

        public ActionResult PartialView()
        {
            return View();
        }

        public ActionResult ChildAction()
        {
            return View();
        }
        public ActionResult ForChildAction(int i)
        {

            ViewData.Model = DateTime.Now.AddDays(i).ToString("yyyy-MM-dd HH:mm:ss ffff");
            return View();
        }
        public ActionResult Ajax()
        {
            return View();
        }
        public ActionResult ForAJax(int i)
        {
            Thread.Sleep(i*new Random().Next(1000, 2000));
            ViewData.Model = DateTime.Now.AddDays(i).ToString("yyyy-MM-dd HH:mm:ss ffff");
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