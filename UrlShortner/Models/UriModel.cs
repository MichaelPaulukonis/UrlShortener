using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using UrlShortener.Helpers;

namespace UrlShortener.Models
{
    public class UriModel
    {
        public UriModel(Utility util)
        {
            this.util = util;
        }

        public UriModel(Utility util, string uri)
            // TODO: put this in the util, as well
            // the Uri does not need to know how to make a confirmation code, just to make one
            : this(util, uri, util.ConfirmationToken())
        {
        }

        public UriModel(Utility util, string uri, string confirmationcode)
            : this(util)
        {
            this.FullURI = uri;
            this.ConfirmationCode = confirmationcode;
        }

        private readonly Utility util;

        // this will be user-provided token (email or otherwise) or auto-generated string
        public string ConfirmationCode { get; private set; }
        private string _uri;
        public string FullURI
        {
            get
            { return _uri; }
            private set
            {
                _uri = value;
                this.ShortURI = util.Shorten(value);
            }
        }

        // this isn't the "short location" so much as it is a computed value that will be used as a key to retrieve the original
        public string ShortURI { get; private set; }

    }
}