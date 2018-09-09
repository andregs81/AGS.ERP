using AGS.ERP.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AGS.ERP.Application.Interfaces
{
    public interface IFornecedorAppService : IDisposable
    {
        void Add(FornecedorViewModel fornecedorViewModel);
        FornecedorViewModel GetById(int id);
        IEnumerable<FornecedorViewModel> GetAll();
        void Update(FornecedorViewModel fornecedorViewModel);
        void Remove(int id);
        int ObterTotalRegistros(string pesquisa);
        IEnumerable<FornecedorViewModel> ObterfornecedorGrid(int page, string pesquisa);
    }
}
