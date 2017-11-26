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
        public void Instantiation_with_IShortener_throws_no_Exception()
        {
            try
            {
                var util = new Shortener();
                var url = new UriModel(util);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Expected no exception but got: {ex.ToString()}");
            }
        }


        [TestMethod]
        public void Instantiation_with_IShortener_and_URI_throws_no_Exception()
        {
            try
            {
                var uri = "https://www.google.com";
                var util = new Shortener();
                var url = new UriModel(util, uri);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Expected no exception but got: {ex.ToString()}");
            }
        }

        [TestMethod]
        public void Instantiation_with_IShortener_and_URI_confirmation_token_not_null()
        {
            var uri = "https://www.google.com";
            var util = new Shortener();
            var url = new UriModel(util, uri);
            Assert.IsNotNull(url.ConfirmationCode, "Confirmation code should be auto-populated when not provided");
        }

        private UriModel Setup(string schema, string location)
        {
            var util = new Shortener();
            return new UriModel(util, $"{schema}{location}");
        }


        [TestMethod]
        public void URI_schema_is_correct()
        {
            var schema = "https://";
            var location = "www.google.com";
            var uri = Setup(schema, location);
            Assert.AreEqual(schema, uri.Schema, "Schema should be as provided");
            Assert.AreEqual(location, uri.Location, "Location should be as provided");
            Assert.AreEqual($"{schema}{location}", uri.FullURI, "Full URI should be as expected");
        }

        [TestMethod]
        public void ShortUrl_is_populated()
        {
            var schema = "https://";
            var location = "www.google.com";
            var uri = Setup(schema, location);
            Assert.IsFalse(String.IsNullOrWhiteSpace(uri.ShortLocation), "ShortLocation should be populated.");
        }

        [TestMethod]
        public void ShortUrl_is_populated_as_expected()
        {
            var schema = "https://";
            var location = "www.google.com";
            var uri = Setup(schema, location);
            Assert.AreEqual(uri.ShortURI, $"{uri.Schema}{uri.ShortLocation}", "ShortUri should be schema plus ShortLocation.");
            // TODO: test better for starting with schema, ending with shortLocation
        }

    }
}
