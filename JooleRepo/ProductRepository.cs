using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleCore;

namespace JooleRepo
{
    class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(JooleDatabaseEntities context) : base(context)
        { 
        }

        public JooleDatabaseEntities JBContext
        {
            get { return context as JooleDatabaseEntities; }
        }

        public IEnumerable<Product> getSubcategory(string subcategory)
        {
            return JBContext.Products.Where(product => product.SubCategory == subcategory).ToList();
        }
    }
}
