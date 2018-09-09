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
            
        }

        [Key]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string UF { get; set; }

        [Required(ErrorMessage ="Campo obrigátorio")]
        public string Nome { get; set; }


    }
}
