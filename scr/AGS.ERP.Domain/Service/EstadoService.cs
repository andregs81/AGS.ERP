using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Domain.Interfaces.Repository;
using AGS.ERP.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Domain.Service
{
    public class EstadoService : ServiceBase<Estado>, IEstadoService
    {
        private readonly IEstadoRepository _estadoRepository;
        public EstadoService(IEstadoRepository estadoRepository)
            :base(estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        public Estado GetByUF(string UF)
        {
            return _estadoRepository.GetByUF(UF);
        }
    }
}
