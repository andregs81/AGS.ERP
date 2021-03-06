﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AGS.ERP.Application.ViewModel
{
    public class CidadeViewModel
    {
        public CidadeViewModel()
        {
            
        }

        [Key]
        public int CidadeId { get; set; }
        [Required(ErrorMessage ="Campo Cidade é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Estado é obrigatório")]
        public string UF { get; set; }

    }
}
