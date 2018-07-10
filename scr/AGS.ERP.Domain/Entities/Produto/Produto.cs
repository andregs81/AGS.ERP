
using System.Collections.Generic;

namespace AGS.ERP.Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            UnidadesMedida = new List<UnidadeMedidaProduto>();
        }

        public int ProdutoId { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<UnidadeMedidaProduto> UnidadesMedida { get; set; }
    }
}
