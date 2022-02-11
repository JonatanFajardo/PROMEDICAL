using PROMEDICAL.Logic.Interfaces;
using PROMEDICAL.Logic.Interfaces.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Logic.Repositories.General
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ICargosRepository cargosRepository)
        {
            cargos = cargosRepository;

        }
        public ICargosRepository cargos { get; }
    }
}
