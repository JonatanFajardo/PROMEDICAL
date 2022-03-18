using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces.General;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROMEDICAL.Logic.Interfaces.Especific
{
    public interface IPrescripcionesRepository : IGenericCatalogsRepository<tbPrescripciones>
    {
        Task<IEnumerable<tbPrescripciones>> ListAsync(int id);
    }
}
