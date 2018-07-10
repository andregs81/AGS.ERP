using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Interfaces.Specification;
using System.Linq;

namespace AGS.ERP.Domain.Specification.Clientes
{
    public class ClientePossuiEnderecoCadastradoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return cliente.Endereco != null && cliente.Endereco.Any();
        }
    }
}
