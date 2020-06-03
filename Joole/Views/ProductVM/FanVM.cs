using JooleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joole.Views.ProductVM
{
    public class FanVM
    {
        public IEnumerable<Fan> Fans { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public Fan FanDetail { get; set; }

        public Product ProductFanDetail { get; set; }
    }
}