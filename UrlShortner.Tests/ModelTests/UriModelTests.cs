using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UrlShortener.Models;
using UrlShortener.Helpers;

namespace UrlShortener.Tests.Models
{
    [TestClass]
    public class UriModelTests
    {
        [TestMethod]
        public void Instantiation_with_Utility_throws_no_Exception()
        {
            try
            {
                var util = new Utility();
                var url = new UriModel(util);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Expected no exception but got: {ex.ToString()}");
            }
        }


        [TestMethod]
        public void Instantiation_with_Utility_and_URI_throws_no_Exception()
        {
            try
            {
                var uri = "https://www.google.com";
                var util = new Utility();
                var url = new UriModel(util, uri);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Expected no exception but got: {ex.ToString()}");
            }
        }

        [TestMethod]
        public void Instantiation_with_Utility_and_URI_confirmation_token_not_null()
        {
            var uri = "https://www.google.com";
            var util = new Utility();
            var url = new UriModel(util, uri);
            Assert.IsNotNull(url.ConfirmationCode, "Confirmation code should be auto-populated when not provided");
        }

        // TODO: WHAOH BESSIE
        // this is all wrong - the short version is a hash to EVERYTHING
        // shchema plus location (and everything)
        private UriModel Setup(string schema, string location)
        {
            var util = new Utility();
            return new UriModel(util, $"{schema}{location}");
        }


        [TestMethod]
        public void ShortUrl_is_populated()
        {
            var schema = "https://";
            var location = "www.google.com";
            var uri = Setup(schema, location);
            Assert.IsFalse(String.IsNullOrWhiteSpace(uri.ShortURI), "ShortUri should be populated.");
        }

        [TestMethod]
        public void ShortUrl_is_populated_as_expected()
        {
            var schema = "https://";
            var location = "www.google.com";
            var uri = Setup(schema, location);
            var util = new Utility();
            var shorty = util.Shorten(schema + location);
            Assert.AreEqual(uri.ShortURI, shorty, "ShortUri should be a repeated shortened version of URI");
        }

    }
}
