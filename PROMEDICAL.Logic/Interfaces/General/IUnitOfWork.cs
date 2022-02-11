using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Logic.Interfaces.General
{
    public interface IUnitOfWork
    {
        ICargosRepository cargos { get; }
    }
}
