using System;

namespace JooleRepo
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }

    }
}
