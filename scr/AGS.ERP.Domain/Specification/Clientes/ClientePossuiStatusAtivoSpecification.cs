using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Domain.Specification.Clientes
{
    public class ClientePossuiStatusAtivoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return cliente.Ativo;
        }
    }
}
