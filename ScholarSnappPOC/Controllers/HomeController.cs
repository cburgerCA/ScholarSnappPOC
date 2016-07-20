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

        public ActionResult Index()
        {
            var SSUrl = ConfigurationManager.AppSettings["SSUrl"].ToString();
            SSUrl += "?response_type=code";
            SSUrl += "&client_id=" + Server.UrlPathEncode(ConfigurationManager.AppSettings["SSClientId"].ToString());
            SSUrl += "&redirect_uri=" + Server.UrlPathEncode(ConfigurationManager.AppSettings["SSRedirect_Uri"].ToString());
            ViewBag.SSUrl = SSUrl;
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

        public ActionResult ScholarSnappConnect(string error, string code, string state, string extra)
        {
            ViewBag.Error = error;
            ViewBag.Code = code;
            ViewBag.state = state;
            ViewBag.Extra = extra;

            return View();
        }
    }
}