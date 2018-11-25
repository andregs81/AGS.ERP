using AGS.ERP.Domain.Entities.Geografia;
using System.Collections.Generic;

namespace AGS.ERP.Domain.Interfaces.Services
{
    public interface IEnderecoService : IService<Endereco>
    {
        IEnumerable<Endereco> ObterEnderecoPorCliente(int idCliente);
        IEnumerable<Endereco> ObterEnderecoPorFornecedor(int idFornecedor);
    }
}
