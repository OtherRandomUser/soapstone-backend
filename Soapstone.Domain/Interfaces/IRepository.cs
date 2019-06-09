using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soapstone.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<int> AddAsync(TEntity entity);
        Task<int> UpdateAsync(TEntity entity);
        Task<int> DeleteAsync(TEntity entity);
        // TODO Extract defaults
        Task<IEnumerable<TEntity>> GetPage(int skip = 0, int take = 25);
        Task<IQueryable<TEntity>> GetQueryable();
        Task<TEntity> GetById(Guid id);

    }
}