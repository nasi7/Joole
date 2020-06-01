using JooleCore;
using System.Collections.Generic;
using System.Linq;

namespace JooleRepo
{
    class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(JooleDatabaseEntities context) : base(context)
        {
        }

        public JooleDatabaseEntities JBContext
        {
            get { return context as JooleDatabaseEntities; }
        }

        IEnumerable<User> IUserRepository.getValidUser(string username, string password)
        {
            return JBContext.Users.Where(user => user.Username == username).ToList();
        }
    }
}
