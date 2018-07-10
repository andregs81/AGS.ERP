using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Domain.Interfaces.Repository;
using AGS.ERP.Infra.Data.Context;

namespace AGS.ERP.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AgsErpContext context) : base(context)
        {

        }
    }
}
