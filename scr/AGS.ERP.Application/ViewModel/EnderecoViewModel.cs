﻿using System.ComponentModel.DataAnnotations;

namespace AGS.ERP.Application.ViewModel
{
    public class EnderecoViewModel
    {
        public EnderecoViewModel()
        {
            Cidade = new CidadeViewModel();
            Estado = new EstadoViewModel();
        }

        [Key]
        public int EnderecoId { get; set; }
        [Required(ErrorMessage ="O CEP é obrigatório")]
        [MaxLength(10, ErrorMessage = "O tamanho máximo é {1}")]
        public string CEP { get; set; }

        [Required(ErrorMessage ="Logradouro Campo requerido")]
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

        public int CidadeId { get; set; }
        public string UF { get; set; }
        public int? ClienteId  { get; set; }
        public int? FornecedorId { get; set; }

        //public virtual ClienteViewModel Cliente { get; set; } Removi essa propriedade pois estava dando erro de referencia circular com ClienteViewModel
        public virtual CidadeViewModel Cidade { get; set; }
        public virtual EstadoViewModel Estado { get; set; }

    }
}
