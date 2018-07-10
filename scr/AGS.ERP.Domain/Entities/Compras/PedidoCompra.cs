using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Domain.Entities.Compras
{
    public class PedidoCompra
    {
        public PedidoCompra()
        {
            Produtos = new List<ItensCompra>();
        }
        public int PedidoCompraId { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal Valor { get; set; }
        public int FornecedorId { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        public virtual ICollection<ItensCompra> Produtos { get; set; }
    }
}
