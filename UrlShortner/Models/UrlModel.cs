using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UrlShortener.Helpers;

namespace UrlShortener.Models
{
    public class UrlModel
    {
        public UrlModel(IShortener util)
        {
            this.util = util;
        }

        public UrlModel(IShortener util, string uri, string confirmationcode)
            :this(util)
        {
            this.FullURI = uri;
            this.ConfirmationCode = confirmationcode;
        }

        private readonly IShortener util;

        // this will be user-provided token (email or otherwise) or auto-generated string
        public string ConfirmationCode { get; private set; }
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