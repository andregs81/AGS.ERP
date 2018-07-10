using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AGS.ERP.Application.ViewModel
{
    public class ClienteEnderecoViewModel
    {
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

        //Endereco
        public int EnderecoId { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório")]
        [MaxLength(10, ErrorMessage = "O tamanho máximo é {1}")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(200, ErrorMessage = "O tamanho máximo é {1}")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string Bairro { get; set; }

        [Display(Name = "Tipo de Endereço")]
        [Required(ErrorMessage = "O tipo de endereço deve ser selecionado")]
        public TipoEnderecoViewModel TipoEndereco { get; set; }
        [Display(Name ="Cidade")]
        public int CidadeId { get; set; }
        [Display(Name = "Estado")]
        public string UF { get; set; }
    }
}
