using JooleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joole.Views.ProductVM
{
    public class VacuumVM
    {
        public IEnumerable<object> vacs { get; set; }

       //public VacuumVM()
       // {

       // }
       // public VacuumVM(IEnumerable<object> obj) 
       // {
       //     vacs = obj;
       // }

        public Vacumm VacDetail { get; set; }

        public Product ProductVacDetail { get; set; }
    }
}