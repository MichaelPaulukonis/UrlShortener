using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UrlShortener;
using UrlShortener.Controllers;

namespace UrlShortener.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("UrlShortener", result.ViewBag.Title);
        }
    }
}
