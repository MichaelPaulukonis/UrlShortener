using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using UrlShortener.Helpers;

namespace UrlShortener.Models
{
    public class UriModel
    {
        private LocationModel _location;
        private readonly Utility _util;

        public UriModel(Utility util)
        {
            _util = util;
            _location = new LocationModel();
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
            this.ConfirmationCode = (string.IsNullOrEmpty(confirmationcode) ? util.ConfirmationToken() : confirmationcode);
        }


        // this will be user-provided token (email or otherwise) or auto-generated string
        public string ConfirmationCode
        {
            get
            {
                return _location.ConfirmationCode;
            }
            private set
            {
                _location.ConfirmationCode = value;
            }
        }

        private string _uri;
        public string FullURI
        {
            get
            { return _location.FullURI; }
            private set
            {
                _location.FullURI = value;
                _location.ShortURI = _util.Shorten(value);
            }
        }

        // this isn't the "short location" so much as it is a computed value that will be used as a key to retrieve the original
        public string ShortURI
        {
            get
            {
                return _location.ShortURI;
            }
        }

        public LocationModel Location
        {
            get
            {
                return _location;
            }
        }
    }

    // TODO: use this inside of UriModel
    public class LocationModel
    {
        public string ConfirmationCode { get; set; }
        [DisplayName("Full Url")]
        public string FullURI { get; set; }
        public string ShortURI { get; set; }
    }
}