using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrlShortener.Helpers
{
    public interface IShortener
    {
        string Shorten(string message);
    }

    // a robust system might have multiple implementations for testing purposes
    // and a factory and/or dependency injection library to pick one
    // this implementation is probaly non-performant and naive
    // but will suit current demo purposes or providing a hash for a URL
    public class AdlerShortener : IShortener
    {
        public string Shorten(string message)
        {
            return (new AdlerChecksum()).AdlerString(message);
        }
    }

    public interface IConfirmationGenerator
    {
        string Token();
    }

    public class GuidConfirmationGenerator: IConfirmationGenerator
    {
        public string Token()
        {
            return Guid.NewGuid().ToString();
        }
    }

    public class Utility
    {

        // composite class, not the most robust class in the universe
        private IShortener _shortener  = new AdlerShortener();
        private IConfirmationGenerator _confirmationGenerator = new GuidConfirmationGenerator();

        public string Shorten(string message)
        {
            return this._shortener.Shorten(message);
        }

        public string ConfirmationToken()
        {
            return this._confirmationGenerator.Token();
        }
    }
}