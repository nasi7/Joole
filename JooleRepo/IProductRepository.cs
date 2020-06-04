using JooleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JooleRepo
{
    public interface IProductRepository : IRepository<Product>
    {
        //returns all products of a single subcategory
        IEnumerable<Product> getSubcategory(string subcategory);
    }
}
