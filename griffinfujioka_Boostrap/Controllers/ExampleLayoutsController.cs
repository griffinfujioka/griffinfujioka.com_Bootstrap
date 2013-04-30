using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapMvcSample.Controllers
{
    public class ExampleLayoutsController : Controller
    {
        public ActionResult Starter()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View(); 
        }

        public ActionResult About()
        {
            return View(); 
        }

        public ActionResult Portfolio()
        {
            return View(); 
        }

        public ActionResult Contact()
        {
            return View(); 
        }

        public ActionResult Resume()
        {
            Response.Redirect("https://skydrive.live.com/redir?resid=98D6BDF2F20F8BD3!3374&authkey=!AFkkXFDSe21z2tI");
            return View("Home"); 
        }

        public ActionResult Marketing()
        {
            return View();
        }

        public ActionResult Fluid()
        {
            return View();
        }

        public ActionResult Foo()
        {
            return View(); 
        }


        public ActionResult HomePage()
        {
            return View(); 
        }

        public ActionResult Narrow()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult StickyFooter()
        {
            return View("TBD");
        }

        public ActionResult Carousel()
        {
            return View("TBD");
        }
    }
}
