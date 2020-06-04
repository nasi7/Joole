using JooleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joole.Views.ProductVM
{
    public class CouchVM
    {
        public IEnumerable<Couch> Couches { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public Fan CouchDetail { get; set; }

        public Product ProductFanDetail { get; set; }
    }
}