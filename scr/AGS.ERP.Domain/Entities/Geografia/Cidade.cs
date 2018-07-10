namespace AGS.ERP.Domain.Entities.Geografia
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public virtual Estado Estado { get; set; }
    }
}