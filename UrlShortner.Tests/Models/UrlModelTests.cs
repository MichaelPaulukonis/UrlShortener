using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UrlShortener.Models;

namespace UrlShortener.Tests.Models
{
    [TestClass]
    public class UrlModelTests
    {
        [TestMethod]
        public void Instantiation()
        {
            var url = new UrlModel();
        }
    }
}
