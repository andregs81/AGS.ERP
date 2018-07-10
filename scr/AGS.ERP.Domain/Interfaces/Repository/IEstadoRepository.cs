using AGS.ERP.Domain.Entities.Geografia;

namespace AGS.ERP.Domain.Interfaces.Repository
{
    public interface IEstadoRepository : IRepository<Estado>
    {
        Estado GetByUF(string UF);
    }
}
