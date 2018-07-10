using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Application.Interfaces
{
    public interface IAppServiceBase
    {
        //TODO: Modelar para multiplos contextos. Preparar para unit of work
        void BeginTransaction();
        void Commit();

    }
}
