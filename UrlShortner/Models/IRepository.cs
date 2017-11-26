using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlShortener.Models
{
    public interface IRepository<T>
    {

        // TODO: add, get, delete, list
        // for both users and URIs
        IRepository<T> Add(T input);

        IRepository<T> List();

        IRepository<T> Delete(T input);

        T Get(string key);

    }

    // TODO: unit tests
    public class UriRepository : IRepository<UriModel>
    {
        private Dictionary<string, UriModel> _repository = new Dictionary<string, UriModel>();

        public UriRepository() { }

        public IRepository<UriModel> Add(UriModel input)
        {
            _repository.Add(input.ShortURI, input);
            return this;
        }

        public IRepository<UriModel> Delete(UriModel input)
        {
            throw new NotImplementedException();
        }

        public UriModel Get(string key)
        {
            return _repository[key];
        }

        public IRepository<UriModel> List()
        {
            throw new NotImplementedException();
        }
    }

 

}
