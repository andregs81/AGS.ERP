using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Entities.Geografia;
using System.Collections.Generic;

namespace AGS.ERP.Domain.Interfaces.Repository
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        IEnumerable<Endereco> ObterEnderecoPorCliente(int idCliente);
        IEnumerable<Endereco> ObterEnderecoPorFornecedor(int idFornecedor);
    }
}
