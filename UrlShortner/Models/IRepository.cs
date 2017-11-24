using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlShortner.Models
{
    interface IRepository<T>
    {

        // TODO: add, get, delete, list
        // for both users and URIs
        IRepository<T> Add(T input);

        IRepository<T> List();

        IRepository<T> Delete(T input);

        T Get(string key);
        
    }


}
