using AGS.ERP.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Application.Interfaces
{
    public interface IEnderecoAppService : IDisposable
    {
        IEnumerable<EnderecoViewModel> ObterEnderecoPorCliente(int idCliente);
        IEnumerable<EnderecoViewModel> ObterEnderecoPorFornecedor(int idFornecedor);
        void Add(ClienteEnderecoViewModel clienteEndereco);
        void Update(ClienteEnderecoViewModel clienteEndereco);
        EnderecoViewModel GetById(int id);
    }
}
