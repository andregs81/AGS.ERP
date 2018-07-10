using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Domain.Entities.Venda
{
    public class Pedido
    {
        public Pedido()
        {
            Produtos = new List<Produto>();
        }

        public int PedidoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal Valor { get; set; }
        public int ClienteId { get; set; }
        public TipoVenda  TipoVenda { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
