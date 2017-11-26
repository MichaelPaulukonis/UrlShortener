using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UrlShortener.Helpers;

namespace UrlShortner.Tests.HelperTests
{
    [TestClass]
    public class AdlerChecksumTests
    {
        [TestMethod]
        public void Adler_Instantiation_no_exception()
        {
            try
            {
                var ac = new AdlerChecksum();
            }
            catch (Exception ex)
            {
                Assert.Fail($"Expected no exception but got: {ex.ToString()}");
            }
        }

        [TestMethod]
        public void Adler_as_shortener()
        {
            var ac = new AdlerChecksum();
            var url = "http://www.google.com";
            var shortchecksum = ac.AdlerString(url);
            Assert.IsNotNull(shortchecksum, "AdlerString should not be null");
        }

        [TestMethod]
        public void Repeated_Adler_is_identical()
        {
            var ac = new AdlerChecksum();
            var url = "http://www.google.com";
            var chk1 = ac.AdlerString(url);
            var chk2 = ac.AdlerString(url);

            Assert.AreEqual(chk1, chk2, "Multiple checksums are identical for same input string");
        }

        // TODO: more tests for null, empty-string, etc. 
    }
}
