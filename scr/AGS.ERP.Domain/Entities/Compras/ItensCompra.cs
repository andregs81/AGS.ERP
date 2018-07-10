namespace AGS.ERP.Domain.Entities.Compras
{
    public class ItensCompra
    {
        public int ItensCompraId { get; set; }
        public int PedidoCompraId { get; set; }
        public int ProdutoId { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual PedidoCompra PedidoCompra { get; set; }
    }
}