using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Domain.Interfaces.Repository;
using AGS.ERP.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Domain.Service
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;
        public CidadeService(ICidadeRepository cidadeRepository)
            : base(cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }
    }
}
