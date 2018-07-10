using AGS.ERP.Application.Interfaces;
using AGS.ERP.Application.ViewModel;
using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Application.Services
{
    public class CidadeAppService : AppServiceBase, ICidadeAppService
    {
        private readonly ICidadeService _cidadeService;
        public CidadeAppService(ICidadeService cidadeService)
        {
            _cidadeService = cidadeService;
        }
        public void Add(CidadeViewModel obj)
        {
            var cidade = Mapper.Map<CidadeViewModel, Cidade>(obj);
            _cidadeService.Add(cidade);
            _cidadeService.SaveChanges();
        }


        public IEnumerable<CidadeViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Cidade>, IEnumerable<CidadeViewModel>>(_cidadeService.GetAll());
        }

        public CidadeViewModel GetById(int id)
        {
            return Mapper.Map<Cidade, CidadeViewModel>(_cidadeService.GetById(id));
        }

        public void Remove(CidadeViewModel obj)
        {
            var cidade = Mapper.Map<CidadeViewModel, Cidade>(obj);
            _cidadeService.Remove(cidade);
            _cidadeService.SaveChanges();
        }


        public void Update(CidadeViewModel obj)
        {
            var cidade = Mapper.Map<CidadeViewModel, Cidade>(obj);
            _cidadeService.Update(cidade);
            _cidadeService.SaveChanges();
        }

        public void Dispose()
        {
            _cidadeService.Dispose();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
