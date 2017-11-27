using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrlShortener.Models;

namespace UrlShortener.Controllers
{
    public class DeleteController : BaseController
    {
        // GET: Delete
        public ActionResult Index()
        {
            var repo = (UriRepository)Session["repo"];

            return View(nameof(Delete), repo);
        }


        // GET: Delete/Delete/{key}
        public ActionResult Delete(string id)
        {
            var repo = (UriRepository)Session["repo"];
            repo.Delete(id);
            return View(nameof(Delete), repo);
        }

    }
}
