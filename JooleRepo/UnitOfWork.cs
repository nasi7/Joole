using JooleCore;
using System;

namespace JooleRepo
{
    public class UnitOfWork : IDisposable
    {
        // private readonly JooleDatabaseEntities _context;


        private JooleDatabaseEntities context = new JooleDatabaseEntities();
        private Repository<User> userRepository;
        private Repository<Product> productRepository;

        public Repository<Couch> couchRepository = new Repository<Couch>(new JooleDatabaseEntities());
        public Repository<Fan> fanRepository = new Repository<Fan>(new JooleDatabaseEntities());
        public Repository<Table> tableRepository = new Repository<Table>(new JooleDatabaseEntities());
        public Repository<TableSaw> tablesawRepository = new Repository<TableSaw>(new JooleDatabaseEntities());
        public Repository<Toaster> toasterRepository = new Repository<Toaster>(new JooleDatabaseEntities());
        public Repository<TV> tvRepository = new Repository<TV>(new JooleDatabaseEntities());
        public Repository<Vacumm> vacummRepository = new Repository<Vacumm>(new JooleDatabaseEntities());
        public Repository<Workbench> WorkbenchRepository = new Repository<Workbench>(new JooleDatabaseEntities());



        /* public UnitOfWork(PlutoContext context)
         {
             _context = context;
             Courses = new CourseRepository(_context);
             Authors = new AuthorRepository(_context);
         }

         public ICourseRepository Courses { get; private set; }
         public IAuthorRepository Authors { get; private set; }*/

        public Repository<User> UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new UserRepository(context);
                }
                return userRepository;
            }
        }

        public Repository<Product> ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new Repository<Product>(context);
                }
                return productRepository;
            }
        }


        public void Complete()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
