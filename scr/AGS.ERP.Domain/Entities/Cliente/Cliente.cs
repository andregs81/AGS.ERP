using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Domain.ValueObjects;
using AGS.ERP.Domain.Validation;
using System.Collections.Generic;

namespace AGS.ERP.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            Endereco = new List<Endereco>();
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public bool Ativo { get; set; }

        public virtual ICollection<Endereco> Endereco { get; set; }

        public ValidationResult ResultadoValidacao { get; private set; }

        public bool IsValid()
        {
            var fiscal = new ClienteEstaAptoParaCadastroNoSistema();

            ResultadoValidacao = fiscal.Validar(this);

            return ResultadoValidacao.IsValid;
        }
    }
}
