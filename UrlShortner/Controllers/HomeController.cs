using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrlShortener.Models;

namespace UrlShortener.Controllers
{
    public class HomeController : BaseController
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
            // TODO: controller's dependencies should be mocked!
            repo.Add(uri);
            Session["repo"] = repo;

            var location = new LocationModel();
            return View(location);
        }

        [HttpPost]
        public ActionResult Shortened(LocationModel location)
        {
            var repo = (UriRepository)Session["repo"];
            if (repo == null) { repo = new UriRepository(); }
            var uri = new UriModel(new Helpers.Utility(), location.FullURI, location.ConfirmationCode);
            repo.Add(uri);
            uri = repo.Get(uri.ShortURI); // if uri already exists, use original confirmation token, etc.
            Session["repo"] = repo;

            return View(nameof(Shortened), uri.Location);
        }
    }

}
