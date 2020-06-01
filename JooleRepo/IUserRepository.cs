using JooleCore;
using System.Collections.Generic;

namespace JooleRepo
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> getValidUser(string username, string password);
    }
}

