using AGS.ERP.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Application.Interfaces
{
    public interface IEstadoAppService : IDisposable
    {
        void Add(EstadoViewModel obj);
        EstadoViewModel GetByUF(string UF);
        IEnumerable<EstadoViewModel> GetAll();
        void Update(EstadoViewModel obj);
        void Remove(int id);
        int SaveChanges();
    }
}
