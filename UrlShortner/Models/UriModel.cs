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
        public UriModel(IShortener util)
        {
            this.util = util;
        }

        public UriModel(IShortener util, string uri)
            : this(util, uri, Guid.NewGuid().ToString() )
        {
        }

        public UriModel(IShortener util, string uri, string confirmationcode)
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
                var uriRgx = Regex.Match(value, @"^([a-zA-Z]*://)(.*)$", RegexOptions.IgnoreCase);
                if (uriRgx.Success && uriRgx.Groups.Count == 3)
                {
                    this.Schema = uriRgx.Groups[1].Value;
                    this.Location = uriRgx.Groups[2].Value;
                } else
                {
                    throw new ArgumentException($"'{value}' is not a recognized URI schema.");
                }
            }
        }
        public string ShortURI { get { return $"{this.Schema}{this.ShortLocation}"; } }
        // TODO: technically, does the schema include or exclude "://" ?
        public string Schema { get; private set; }
        public string Location { get; private set; }
        public string ShortLocation { get; private set; }
    }
}