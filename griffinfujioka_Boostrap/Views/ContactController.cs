using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace griffinfujioka_Boostrap.Views
{
    public class ContactControlle : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View();
        }

        public void sendEmailBtnClick()
        {
            MailMessage m = new MailMessage();
            SmtpClient sc = new SmtpClient();
            m.From = new MailAddress("from@gmail.com", "Display name");
            m.To.Add(new MailAddress("to@domain.com", "Display name To"));
            m.CC.Add(new MailAddress("CC@yahoo.com", "Display name CC"));
            //similarly BCC
            m.Subject = "Test";
            m.Body = "This is a Test Mail";
        }

    }
}
