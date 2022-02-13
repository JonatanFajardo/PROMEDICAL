using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROMEDICAL.Logic.Interfaces.General
{
    public interface IGenericRepository<T, D>
    {
        Task<IEnumerable<D>> GetAll();
        Task<IEnumerable<D>> GetOneId();
    }
}
