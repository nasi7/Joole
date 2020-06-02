using JooleCore;
using System.Collections.Generic;
using System.Linq;

namespace JooleRepo
{
    public class UserRepository : Repository<User>
    {

        public UserRepository(JooleDatabaseEntities context) : base(context)
        {
        }

        public JooleDatabaseEntities JBContext
        {
            get { return context as JooleDatabaseEntities; }
        }

        public IEnumerable<User> getValidUser(string username, string password)
        {
            return JBContext.Users.Where(user => user.Username == username && user.Password == password).ToList();
        }

    }
}
