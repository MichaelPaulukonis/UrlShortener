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

    public class UriRepository : IRepository<UrlModel>
    {
        private Dictionary<string, UrlModel> _repository = new Dictionary<string, UrlModel>();

        public UriRepository() { }

        public IRepository<UrlModel> Add(UrlModel input)
        {
            throw new NotImplementedException();
        }

        public IRepository<UrlModel> Delete(UrlModel input)
        {
            throw new NotImplementedException();
        }

        public UrlModel Get(string key)
        {
            throw new NotImplementedException();
        }

        public IRepository<UrlModel> List()
        {
            throw new NotImplementedException();
        }
    }

 

}
