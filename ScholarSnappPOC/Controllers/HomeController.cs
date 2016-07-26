using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScholarSnappPOC.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// Home Page: where user enters in email and extra information to pass back to the redirecturl.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var SSUrl = ConfigurationManager.AppSettings["SSUrl"].ToString();
            SSUrl += "?response_type=code";
            SSUrl += "&client_id=" + Server.UrlEncode(ConfigurationManager.AppSettings["SSClientId"].ToString());
            SSUrl += "&redirect_uri=" + Server.UrlEncode(ConfigurationManager.AppSettings["SSRedirect_Uri"].ToString());
            ViewBag.SSUrl = SSUrl;
            return View();
        }

        //Not Used - Default page
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Not Used - Default page
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Redirection landing.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="code">The code.</param>
        /// <param name="state">The state.</param>
        /// <returns></returns>
        public ActionResult ScholarSnappConnect(string error, string code, string state)
        {
            ViewBag.Error = error;
            ViewBag.Code = code;
            List<string> stateItems = state.Split('|').ToList();
            ViewBag.state = stateItems[0];
            if (stateItems.Count > 1)
            {
                ViewBag.Extra = stateItems[1];
            }

            return View();
        }
    }
}