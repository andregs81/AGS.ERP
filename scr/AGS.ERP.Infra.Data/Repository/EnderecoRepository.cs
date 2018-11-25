using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Endereco> ObterEnderecoPorCliente(int idCliente)
        {
            return base.DbSet.Where(e => e.ClienteId == idCliente);
        }

        public IEnumerable<Endereco> ObterEnderecoPorFornecedor(int idFornecedor)
        {
            return base.DbSet.Where(e => e.FornecedorId == idFornecedor);
        }
    }
}
