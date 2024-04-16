using TcaSolutions.Entities;

namespace TcaSolutions.Data.Interfaces
{
    public interface IBaseRepository
    {
        Task<TEntity> Create<TEntity>(TEntity entity) where TEntity : EntityBase;
        Task<TEntity> Delete<TEntity>(Guid idEntity) where TEntity : EntityBase;
        Task<TEntity> Read<TEntity>(Guid idEntity) where TEntity : EntityBase;
        Task<TEntity> Update<TEntity>(TEntity entity) where TEntity : EntityBase;
    }
}