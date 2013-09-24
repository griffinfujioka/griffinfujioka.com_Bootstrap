using griffinfujioka_Boostrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace BootstrapMvcSample.Controllers
{
    public class ExampleLayoutsController : Controller
    {
        public ActionResult sendEmailBtnClick(EmailMessage message)
        {
            //if (message == null)
            //    return View("Index"); 


            //var name = message.Name;
            //var fromAddress = message.FromEmailAddress;
            //var subject = message.Subject;
            //var body = message.Message;

            //MailMessage m = new MailMessage();
            //SmtpClient sc = new SmtpClient();
            //m.From = new MailAddress("fujiokag@hotmail.com", name);
            //m.To.Add(new MailAddress("fujiokag@hotmail.com", "Griffin Fujioka"));
            //m.Subject = subject;
            //m.Body = body;

            //sc.Host = "smtp.live.com";
            //sc.Port = 587;
            //sc.UseDefaultCredentials = false;
            //sc.Credentials = new System.Net.NetworkCredential("fujiokag@hotmail.com", "Fujioka32");

            //sc.EnableSsl = true; // runtime encrypt the SMTP communications using SSL
            ////sc.Send(m); 
            return View("Index"); 
        }

        public ActionResult Index()
        {
            return View();
        }

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
