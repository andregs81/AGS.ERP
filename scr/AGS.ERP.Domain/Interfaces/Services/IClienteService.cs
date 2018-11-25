using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.ValueObjects;

namespace AGS.ERP.Domain.Interfaces.Services
{
    public interface IClienteService : IService<Cliente>
    {
        ValidationResult AddCliente(Cliente cliente);
        Cliente ClienteCompleto(int id);
    }
}
