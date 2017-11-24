using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrlShortener.Models
{
    public class UrlModel
    {
        // this will be an email, or other provided token
        public string UserId { get; private set; }
        public string FullURI {
            get { return $"{this.Schema}//{this.Location}"; }
            private set
            {
                throw new NotImplementedException();
            }
        }
        public string ShortURI { get { return $"{this.Schema}//{this.ShortLocation}"; } }
        public string Schema { get; private set; }
        public string Location { get; private set; }
        public string ShortLocation { get; private set; }
    }
}