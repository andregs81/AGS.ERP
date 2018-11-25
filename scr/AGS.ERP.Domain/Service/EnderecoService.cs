using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Domain.Interfaces.Repository;
using AGS.ERP.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Domain.Service
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository) 
            : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public IEnumerable<Endereco> ObterEnderecoPorCliente(int idCliente)
        {
            return _enderecoRepository.ObterEnderecoPorCliente(idCliente);
        }

        public IEnumerable<Endereco> ObterEnderecoPorFornecedor(int idFornecedor)
        {
            return _enderecoRepository.ObterEnderecoPorFornecedor(idFornecedor);
        }
    }
}
