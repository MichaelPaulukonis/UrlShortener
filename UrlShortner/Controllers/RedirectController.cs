using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrlShortener.Models;

namespace UrlShortener.Controllers
{
    public class RedirectController : BaseController
    {
        // GET: Redirect
        public ActionResult Redirect()
        {
            return View();
        }


        public ActionResult Redirector(string id)
        {
            // TODO: if key is not found, display message
            var repo = (UriRepository)Session["repo"];
            if (repo == null || id == null || !repo.Contains(id))
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Destination = repo.Get(id).FullURI;
            return View(nameof(Redirect));
        }
    }
}