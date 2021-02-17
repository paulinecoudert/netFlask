using NetFlask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlask.Infra
{
    public static class SessionUtils
    {     
        public static int Compteur
        {
            get {
                if (HttpContext.Current.Session["NbPage"] == null)
                    HttpContext.Current.Session["NbPage"] = 0;
                return (int)HttpContext.Current.Session["NbPage"]; //Unboxing
            }

            set { HttpContext.Current.Session["NbPage"] = value; } //Boxing
        }

        public static MovieModel ZeMovie
        {
            get { return (MovieModel)HttpContext.Current.Session["ZeMovie"]; }

            set { HttpContext.Current.Session["ZeMovie"] = value; }
        }


        public static bool IsLogged
        {
            get { 
                
                if(HttpContext.Current.Session["logged"]==null)
                {
                    HttpContext.Current.Session["logged"] = false;
                }
                return (bool)HttpContext.Current.Session["logged"]; }

            set { HttpContext.Current.Session["logged"] = value; }
        }
    }
}