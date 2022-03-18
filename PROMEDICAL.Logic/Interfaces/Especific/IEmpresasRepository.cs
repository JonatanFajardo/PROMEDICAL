using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces.General;

namespace PROMEDICAL.Logic.Interfaces.Especific
{
    public interface IEmpresasRepository : IGenericRepository<tbEmpresas, UDP_Empresas_FindResult>
    {
    }
}
