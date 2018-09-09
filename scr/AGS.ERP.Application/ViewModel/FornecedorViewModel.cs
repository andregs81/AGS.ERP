using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AGS.ERP.Application.ViewModel
{
    public class FornecedorViewModel
    {
        [Key]
        public int FornecedorId { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }

        public virtual IEnumerable<EnderecoViewModel> Endereco { get; set; }
    }
}
