using AGS.ERP.Application.Validation;
using AGS.ERP.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace AGS.ERP.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        ValidationAppResult Add(ClienteEnderecoViewModel clienteEnderecoViewModel);
        ClienteViewModel GetById(int id);
        IEnumerable<ClienteViewModel> GetAll();
        void Update(ClienteViewModel clienteViewModel);
        void Remove(int id);
        int ObterTotalRegistros(string pesquisa);
        IEnumerable<ClienteViewModel> ObterClientesGrid(int page, string pesquisa);
    }
}
