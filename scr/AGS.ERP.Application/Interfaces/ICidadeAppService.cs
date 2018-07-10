using AGS.ERP.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Application.Interfaces
{
    public interface ICidadeAppService : IDisposable
    {
        void Add(CidadeViewModel obj);
        CidadeViewModel GetById(int id);
        IEnumerable<CidadeViewModel> GetAll();
        void Update(CidadeViewModel obj);
        void Remove(CidadeViewModel obj);
        int SaveChanges();
    }
}
