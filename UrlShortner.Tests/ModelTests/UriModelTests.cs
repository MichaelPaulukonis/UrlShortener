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
    }
}
