using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Interfaces.Repository;
using AGS.ERP.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AGS.ERP.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(AgsErpContext context) : base(context)
        {

        }

        public virtual Cliente ClienteCompleto(int id)
        {
            return base.DbSet.Where(c => c.ClienteId == id).Include(e => e.Endereco).FirstOrDefault();
        }
    }
}
