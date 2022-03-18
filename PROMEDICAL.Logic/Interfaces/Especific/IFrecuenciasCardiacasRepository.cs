using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces.General;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROMEDICAL.Logic.Interfaces.Especific
{
    public interface IFrecuenciasCardiacasRepository : IGenericCatalogsRepository<tbFrecuenciasCardiacas>
    {
        Task<IEnumerable<tbFrecuenciasCardiacas>> ListAsync(int id);
    }
}
