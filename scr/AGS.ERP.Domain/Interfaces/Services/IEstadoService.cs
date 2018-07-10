using AGS.ERP.Domain.Entities.Geografia;

namespace AGS.ERP.Domain.Interfaces.Services
{
    public interface IEstadoService : IService<Estado>
    {
        Estado GetByUF(string UF);
    }
}
