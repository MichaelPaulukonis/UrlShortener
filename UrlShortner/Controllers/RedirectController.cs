using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrlShortener.Models;

namespace UrlShortner.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public ActionResult Redirect()
        {
            return View();
        }


        public ActionResult Redirector(string shortUri)
        {
            // TODO: if key is not found, display message
            var repo = (UriRepository)Session["repo"];
            // "foo" and google are used for crude testin purposes
            // TODO: remove crude code when proper not-found handling is implemented
            ViewBag.Destination = (shortUri == "foo" ? "http://www.google.com" : repo.Get(shortUri).FullURI);
            return View(nameof(Redirect));
        }
    }
}