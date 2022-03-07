using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROMEDICAL.Logic.Interfaces.General
{
    public interface IGenericRepository<T, D>
    {
        Task<IEnumerable<D>> ListAsync();
        Task<IEnumerable<D>> FindAsync(int id);
        Task<IEnumerable<D>> DetailAsync(int id);
        Task<Boolean> AddAsync(T entity);
        Task<Boolean> EditAsync(T entity);
        Task<Boolean> RemoveAsync(int id);
    }
}
