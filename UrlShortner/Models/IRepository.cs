using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlShortener.Models
{
    public interface IRepository<T> : IEnumerable<T>
    {

        // TODO: add, get, delete, list
        // for both users and URIs
        IRepository<T> Add(T input);

        //IRepository<T> List();

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
            if (!_repository.ContainsKey(input.ShortURI))
            {
                _repository.Add(input.ShortURI, input);
            }
            return this;
        }

        public IRepository<UriModel> Delete(UriModel input)
        {
            return Delete(input.ShortURI);
        }

        public IRepository<UriModel> Delete(string key)
        {
            if(key != null && _repository.ContainsKey(key))
            {
                _repository.Remove(key);
            }
            return this;
        }

        public bool Contains(string key)
        {
            return _repository.ContainsKey(key);
        }

        public UriModel Get(string key)
        {
            return _repository[key];
        }

        public IEnumerator<UriModel> GetEnumerator()
        {
            return _repository.Values.ToList().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _repository.Values.ToList().GetEnumerator();
        }
    }

  

}
