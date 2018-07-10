using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AGS.ERP.Application.ViewModel
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            
        }

        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage ="O nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O tamanho mínimo para o Nome é {1}")]
        [MaxLength(150, ErrorMessage = "O tamanho máximo para o Nome é {1}")]
        public string Nome { get; set; }

        [MaxLength(11, ErrorMessage ="CPF Inválido")]
        public string CPF { get; set; }
        [MaxLength(14, ErrorMessage = "CPF Inválido")]
        public string CNPJ { get; set; }

        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }

        public virtual IEnumerable<EnderecoViewModel> Endereco { get; set; }


    }
}
