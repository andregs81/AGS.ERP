using AGS.ERP.Domain.Entities.Geografia;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Domain.Entities
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            Endereco = new List<Endereco>();
        }
        public int FornecedorId { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }

        public virtual ICollection<Endereco> Endereco { get; set; }

    }
}
