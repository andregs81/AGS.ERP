using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AGS.ERP.Application.ViewModel
{
    public class EstadoViewModel
    {
        public EstadoViewModel()
        {
            //Cidades = new List<CidadeViewModel>();
        }

        [Key]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string UF { get; set; }

        [Required(ErrorMessage ="Campo obrigátorio")]
        public string Nome { get; set; }

        //public virtual ICollection<CidadeViewModel> Cidades { get; set; }
    }
}
