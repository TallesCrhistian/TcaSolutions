using Microsoft.EntityFrameworkCore.Storage;

namespace TcaSolutions.Data.Interfaces
{
    public interface IWorkUnit
    {
        Task CommitAsync();     
        Task RollbackAsync();
        Task SaveChangesAsync();
        void BeginTransaction();
        void Dispose();
    }
}