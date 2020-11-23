using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Aridos.BL.Data;

namespace Aridos.BL.Repositories.Implements
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AridosContext aridosContext;

        public GenericRepository(AridosContext aridosContext)
        {
            this.aridosContext = aridosContext;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new Exception("La entidad esta vacia");

            aridosContext.Set<TEntity>().Remove(entity);
            await aridosContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await aridosContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await aridosContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            aridosContext.Set<TEntity>().Add(entity);
            await aridosContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            aridosContext.Entry(entity).State = EntityState.Modified;
            //universityContext.Set<TEntity>().AddOrUpdate(entity);
            await aridosContext.SaveChangesAsync();
            return entity;
        }
    }
}
