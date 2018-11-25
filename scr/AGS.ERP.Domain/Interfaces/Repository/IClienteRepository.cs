using AGS.ERP.Domain.Entities;

namespace AGS.ERP.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ClienteCompleto(int id);
    }
}
