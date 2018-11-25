using AGS.ERP.Application.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AGS.ERP.Application.ViewModel
{
    public class ClienteEnderecoViewModel
    {
        public ClienteEnderecoViewModel()
        {
            Endereco = new List<EnderecoViewModel>();
        }

        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O tamanho mínimo para o Nome é {1}")]
        [MaxLength(150, ErrorMessage = "O tamanho máximo para o Nome é {1}")]
        public string Nome { get; set; }

        [MaxLength(11, ErrorMessage = "CPF Inválido")]
        public string CPF { get; set; }
        [MaxLength(14, ErrorMessage = "CPF Inválido")]
        public string CNPJ { get; set; }

        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }

        //Endereco
        [Key]
        public int EnderecoId { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório")]
        [MaxLength(10, ErrorMessage = "O tamanho máximo é {1}")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O Logradouro é obrigatório")]
        [MaxLength(200, ErrorMessage = "O tamanho máximo para logradouro é {1}")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O Número é campo requerido")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Bairro é campo requerido")]
        public string Bairro { get; set; }

        [Display(Name = "Tipo de Endereço")]
        [Required(ErrorMessage = "O tipo de endereço deve ser selecionado")]
        public TipoEnderecoViewModel TipoEndereco { get; set; }
        [Display(Name = "Cidade")]
        [Range(1, int.MaxValue, ErrorMessage = "Selecione uma cidade válida")]
        public int CidadeId { get; set; }
        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Selecione um Estado válido")]
        public string UF { get; set; }

        #region Necessarias para AutoMapper
        public virtual ICollection<EnderecoViewModel> Endereco { get; set; }
        public virtual CidadeViewModel Cidade { get; set; }
        public virtual EstadoViewModel Estado { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
        public int? FornecedorId { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }
        public ValidationResult ResultadoValidacao { get; private set; }

        #endregion Necessarias para AutoMapper

    }
}
