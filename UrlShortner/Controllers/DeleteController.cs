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

        [HttpPost]
        public ActionResult Delete(string submit)
        {
            var repo = (UriRepository)Session["repo"];
            repo.Delete(submit);
            return View(nameof(Delete), repo);
        }

        // TODO: this is the ideal - prompt for confirmation token
        // not yet implemented in the UI
        // s/b a JQuery UI modal input popup. or something.
        //[HttpPost]
        //public ActionResult Delete(string id, string confirmationToken)
        //{
        //    var repo = (UriRepository)Session["repo"];
        //    if (repo.Contains(id))
        //    {
        //        var uri = repo.Get(id);
        //        if (uri.ConfirmationCode == confirmationToken)
        //        {
        //            repo.Delete(id);
        //        }
        //        else
        //        {
        //            // TODO: refuse to delete, and return message to user
        //        }
        //    }
        //    return View(nameof(Delete), repo);
        //}

    }
}
