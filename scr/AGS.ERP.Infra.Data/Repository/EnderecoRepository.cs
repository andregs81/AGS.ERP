using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Interfaces.Repository;
using AGS.ERP.Infra.Data.Context;

namespace AGS.ERP.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(AgsErpContext context) : base(context)
        {

        }
    }
}
