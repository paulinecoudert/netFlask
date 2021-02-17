using NetFlask.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFlask.Areas.Membre.Controllers
{
    public class HomeController : Controller
    {
        // GET: Membre/Home
        public ActionResult Index()
        {
            if(!SessionUtils.IsLogged) return RedirectToAction("Login", "Account", new { area = "" });

            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home", new { area=""});
        }
    }
}