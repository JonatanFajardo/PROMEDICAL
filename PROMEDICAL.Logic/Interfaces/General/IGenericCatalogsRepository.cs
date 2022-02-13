using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROMEDICAL.Logic.Interfaces.General
{
    public interface IGenericCatalogsRepository<T>
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> FindAsync(int id);
        Task<T> DetailAsync(int id);
        Task<Boolean> AddAsync(T entity);
        Task<Boolean> EditAsync(T entity);
        Task<Boolean> RemoveAsync(int id);
    }
}
