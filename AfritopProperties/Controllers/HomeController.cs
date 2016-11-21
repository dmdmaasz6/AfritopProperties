using AfritopProperties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace AfritopProperties.Controllers
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
        public int Email(Email email)
        {
            int status = 1;
            MailMessage mail = new MailMessage();
            mail.Body = email.Message;
            mail.To.Add("chamunorwamichael@gmail.com");
            mail.From = new MailAddress(email.From);
            mail.Subject = email.Subject;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential
            ("chamunorwamichael@gmail.com", "caygersShuvai@1979");// Enter seders User name and password
            smtp.EnableSsl = true;
            smtp.Send(mail);
            return status;
        }
    }
}