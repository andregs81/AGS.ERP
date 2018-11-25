using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Specification.Clientes;
using AGS.ERP.Domain.Validation.Base;

namespace AGS.ERP.Domain.Validation
{
    public class ClienteEstaAptoParaCadastroNoSistema : FiscalBase<Cliente>
    {
        public ClienteEstaAptoParaCadastroNoSistema()
        {
            //var clienteEndereco = new ClientePossuiEnderecoCadastradoSpecification();
            var clienteAtivo = new ClientePossuiStatusAtivoSpecification();

            //base.AdicionarRegra("ClienteSemEndereco", new Regra<Cliente>(clienteEndereco, "Cliente não possui endereço cadastrado"));
            base.AdicionarRegra("ClienteAtivo", new Regra<Cliente>(clienteAtivo, "Cliente não está ativo no sistema"));
        }
    }
}
