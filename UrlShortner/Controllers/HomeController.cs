using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrlShortener.Models;

namespace UrlShortener.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "UrlShortener";

            // TODO: instantiate a repository
            // add something to it for testing
            // store the repository in a Session variable
            // UGH SESSION VARS

            var repo = new UriRepository();
            var uri = new UriModel(new Helpers.Utility(), "http://www.michaelpaulukonis.com");
            repo.Add(uri);
            Session["repo"] = repo;

            return View();
        }
    }
}
