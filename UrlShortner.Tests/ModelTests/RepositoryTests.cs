using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UrlShortener.Models;

namespace UrlShortener.Tests.Models
{
    [TestClass]
    public class RepositoryTests
    {
        [TestMethod]
        public void Instantiation()
        {
            var repo = new UriRepository();
        }
    }
}
