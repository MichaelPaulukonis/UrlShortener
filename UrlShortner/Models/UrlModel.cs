using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrlShortner.Models
{
    public class UrlModel
    {
        public string UserId { get; private set; }
        public string FullURI { get; private set; }
        public string ShortURI { get; private set; }
    }
}