using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using TcaSolutions.Data.Interfaces;

namespace TcaSolutions.Data.WorkUnit
{
    public class WorkUnit : IWorkUnit
    {
        private readonly AppDbContext _appDbContext;
        private IDbContextTransaction _transaction;

        public WorkUnit(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void BeginTransaction()
        {
            _transaction = _appDbContext.Database.BeginTransaction();
        }

        public async Task SaveChangesAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }

        public async Task CommitAsync()
        {
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
            }
        }

        public async Task RollbackAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
            }
        }

        public void Dispose()
        {
            _transaction?.Dispose();
        }    
    }
}
