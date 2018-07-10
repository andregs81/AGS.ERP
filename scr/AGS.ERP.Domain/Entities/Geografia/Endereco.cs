namespace AGS.ERP.Domain.Entities.Geografia
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
        public int CidadeId { get; set; }
        public string UF { get; set; }

        public virtual Cidade Cidade { get; set; }
        public virtual Estado Estado { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}
