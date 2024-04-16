using Microsoft.EntityFrameworkCore;
using TcaSolutions.Data.Interfaces;
using TcaSolutions.Entities;

namespace TcaSolutions.Data.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private AppDbContext _appDbContext;

        public BaseRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<TEntity> Create<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                await this._appDbContext.Set<TEntity>().AddAsync(entity);
            }

            return entity;
        }

        public async Task<TEntity> Read<TEntity>(Guid idEntity) where TEntity : EntityBase
        {
            TEntity entity = await this._appDbContext.Set<TEntity>()
            .FirstOrDefaultAsync(x => x.Id == idEntity);

            return entity;
        }

        public async Task<TEntity> Update<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            var existingEntity = await this._appDbContext.Set<TEntity>()
            .FirstOrDefaultAsync(e => e.Id == entity.Id);

            if (existingEntity is not null)
            {
                entity.CreatedAt = existingEntity.CreatedAt;

                this._appDbContext.Entry(existingEntity).CurrentValues.SetValues(entity);

                return existingEntity;
            }

            return existingEntity;
        }

        public async Task<TEntity> Delete<TEntity>(Guid idEntity) where TEntity : EntityBase
        {
            TEntity entity = await this._appDbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == idEntity);

            if (entity is not null)
            {
                this._appDbContext.Set<TEntity>().Remove(entity);
            }

            return entity;
        }
    }
}
