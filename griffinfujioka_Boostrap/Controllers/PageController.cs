using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace griffinfujioka_Boostrap.Controllers
{
    public class PageController : Controller
    {
        public ActionResult Index()
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
            return View(); 
            //Response.Redirect("https://skydrive.live.com/redir?resid=98D6BDF2F20F8BD3!3374&authkey=!AFkkXFDSe21z2tI");
            //return View("Home");
        }

    }
}
