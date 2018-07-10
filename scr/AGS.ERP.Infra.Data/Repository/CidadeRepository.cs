using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Domain.Interfaces.Repository;
using AGS.ERP.Infra.Data.Context;

namespace AGS.ERP.Infra.Data.Repository
{
    public class CidadeRepository : Repository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(AgsErpContext context) : base(context)
        {

        }
    }
}
