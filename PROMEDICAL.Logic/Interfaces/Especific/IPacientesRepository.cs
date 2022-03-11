using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces.General;

namespace PROMEDICAL.Logic.Interfaces.Especific
{
    public interface IPacientesRepository : IGenericRepository<tbPacientes, UDP_Pacientes_FindResult>
    {
    }
}
