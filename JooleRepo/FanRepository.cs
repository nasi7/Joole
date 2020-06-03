using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using JooleCore;

namespace JooleRepo
{
    public class FanRepository : Repository<Fan>
    {
        public FanRepository(JooleDatabaseEntities context) : base(context)
        {
        }
    }
}
