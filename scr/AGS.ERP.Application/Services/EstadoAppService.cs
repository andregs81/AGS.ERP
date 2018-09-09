using AGS.ERP.Application.Interfaces;
using AGS.ERP.Application.ViewModel;
using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Domain.Interfaces.Services;
using AutoMapper;
using System.Collections.Generic;

namespace AGS.ERP.Application.Services
{
    public class EstadoAppService : AppServiceBase, IEstadoAppService
    {
        private readonly IEstadoService _estadoService;

        public EstadoAppService(IEstadoService estadoService)
        {
            _estadoService = estadoService;
        }

        public void Add(EstadoViewModel obj)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<EstadoViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Estado>, IEnumerable<EstadoViewModel>>(_estadoService.GetAll());
        }

        public EstadoViewModel GetByUF(string UF)
        {
            return Mapper.Map<Estado, EstadoViewModel>(_estadoService.GetByUF(UF));            
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(EstadoViewModel obj)
        {
            throw new System.NotImplementedException();
        }


        public int SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            _estadoService.Dispose();
        }
    }
}
