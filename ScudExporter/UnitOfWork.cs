using System;
using ScudExporter.BL;

namespace ScudExporter
{

    public class UnitOfWork : IDisposable
    {
        private ScudDBContext context = new ScudDBContext();
        private GenericRepository<Emp> empRepository;
        private GenericRepository<Division> divisionRepository;
        private GenericRepository<ScudEvent> scudeventRepository;


        public GenericRepository<ScudEvent> ScudEventRepository
        {
            get
            {

                if (this.scudeventRepository == null)
                {
                    this.scudeventRepository = new GenericRepository<ScudEvent>(context);
                }
                return scudeventRepository;
            }
        }

        public GenericRepository<Emp> EmpRepository
        {
            get
            {

                if (this.empRepository == null)
                {
                    this.empRepository = new GenericRepository<Emp>(context);
                }
                return empRepository;
            }
        }

        public GenericRepository<Division> DivisionRepository
        {
            get
            {

                if (this.divisionRepository == null)
                {
                    this.divisionRepository = new GenericRepository<Division>(context);
                }
                return divisionRepository;
            }
        }

        public void Save()
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
