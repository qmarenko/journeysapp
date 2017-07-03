using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JourneysApp.Controllers
{
    public class WebHookController : Controller
    {
        // GET: WebHook
        public ActionResult Index(string strData)
        {
            var s = strData;
            var http = Request;
            return View();
        }
    }
}