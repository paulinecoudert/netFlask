using NetFlask.Infra;
using NetFlask.Models;
using NetFlask.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace NetFlask.Controllers
{
    public class HomeController : Controller
    {
     
        private void AddPage()
        {
            SessionUtils.Compteur++;
             
        }

        public ActionResult Index()
        {
           


            AddPage();
            ViewBag.Home = "active"; 
            HomeViewModel hm = new HomeViewModel();
        
            return View(hm);

        }


        

        // la route /Home/Videos
        public ActionResult Videos()
        {
            AddPage();
            ViewBag.Videos = "active";
            VideosViewModel vm = new VideosViewModel();
            return View(vm);
        }

        public ActionResult Reviews()
        {
            AddPage();
            ViewBag.Reviews = "active";
            ReviewViewModel model = new ReviewViewModel();
            return View(model);
        }

        public ActionResult Page404()
        {
            AddPage();
            ViewBag.Page404 = "active";
            ReviewViewModel model = new ReviewViewModel();
            return View(model.Slider);
        }

        //Afficher le formulaire
        [HttpGet]
        public ActionResult Contact()
        {
            AddPage();
            ViewBag.Contact = "active";
            return View();
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactModel contact)
        {

            SessionUtils.Compteur++;
            if (ModelState.IsValid)
            {
                DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                if (ctx.SaveContact(contact))
                {
                    ViewBag.SuccessMessage = "Message bien envoyé";
                    sendEmail(contact);
                    return View();
                }
                else
                {
                    ViewBag.ErrorMessage = "Message non enregistré";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Formulaire error";
                return View();
            }
        }

        private void sendEmail(ContactModel contact)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(contact.Email );
            mail.From = new MailAddress("Netflask@interface3.be");
            mail.Subject = "Contact from NetFlask";
            string Body = $"<h1>{contact.Nom} demande </h1><br>{contact.Message}";
            mail.Body = Body;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("user", "password"); // Enter senders User name and password  
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erreur mail : " + ex.Message);
            }
        }
    }
}