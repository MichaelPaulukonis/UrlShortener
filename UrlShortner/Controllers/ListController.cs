using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrlShortener.Models;

namespace UrlShortener.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            var repo = (UriRepository)Session["repo"];

            return View("List", repo);
        }
    }
}