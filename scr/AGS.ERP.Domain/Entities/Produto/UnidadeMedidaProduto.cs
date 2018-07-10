namespace AGS.ERP.Domain.Entities
{
    public class UnidadeMedidaProduto
    {
        public string UnidadeMedidaId { get; set; }
        public int ProdutoId { get; set; }
        public decimal PesoFator { get; set; }


        public virtual UnidadeMedida UnidadeMedida { get; set; }
        public virtual Produto Produto { get; set; }

    }
}