using System.Collections.Generic;
using AGS.ERP.Application.Interfaces;
using AGS.ERP.Application.ViewModel;
using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Interfaces.Services;
using AutoMapper;

namespace AGS.ERP.Application.Services
{
    public class FornecedorAppService : AppServiceBase, IFornecedorAppService
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorAppService(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        public void Add(FornecedorViewModel fornecedorViewModel)
        {
            var fornecedor = Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedorViewModel);
            _fornecedorService.Add(fornecedor);
            _fornecedorService.SaveChanges();

        }


        public IEnumerable<FornecedorViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Fornecedor>, IEnumerable<FornecedorViewModel>>(_fornecedorService.GetAll());
        }

        public FornecedorViewModel GetById(int id)
        {
            return Mapper.Map<Fornecedor, FornecedorViewModel>(_fornecedorService.GetById(id));
        }

        public IEnumerable<FornecedorViewModel> ObterfornecedorGrid(int page, string pesquisa)
        {
            throw new System.NotImplementedException();
        }

        public int ObterTotalRegistros(string pesquisa)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            _fornecedorService.Remove(id);
            _fornecedorService.SaveChanges();
        }

        public void Update(FornecedorViewModel fornecedorViewModel)
        {
            var fornecedor = Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedorViewModel);
            _fornecedorService.Update(fornecedor);
            _fornecedorService.SaveChanges();
        }

        public void Dispose()
        {
            _fornecedorService.Dispose();
        }
    }
}
