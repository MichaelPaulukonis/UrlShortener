using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UrlShortener.Models;
using UrlShortener.Helpers;

namespace UrlShortener.Tests.Models
{
    [TestClass]
    public class UrlModelTests
    {
        [TestMethod]
        public void Instantiation()
        {
            var util = new Shortener();
            var url = new UrlModel(util);
        }
    }
}
