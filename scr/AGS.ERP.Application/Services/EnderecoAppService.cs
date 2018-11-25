using AGS.ERP.Application.Interfaces;
using AGS.ERP.Application.ViewModel;
using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGS.ERP.Application.Services
{
    public class EnderecoAppService : AppServiceBase, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;
        private readonly IClienteAppService _clienteAppService;

        public EnderecoAppService(IEnderecoService enderecoService, IClienteAppService clienteAppService)
        {
            _enderecoService = enderecoService;
            _clienteAppService = clienteAppService;
        }

        public IEnumerable<EnderecoViewModel> ListarEnderecosPorCliente(int clienteId)
        {
            var endereco = _enderecoService.GetAll().Where(e => e.ClienteId == clienteId);            
            return Mapper.Map<IEnumerable<Endereco>, IEnumerable<EnderecoViewModel>>(endereco);
        }


        public IEnumerable<EnderecoViewModel> ObterEnderecoPorCliente(int idCliente)
        {
            var endereco = _enderecoService.ObterEnderecoPorCliente(idCliente);
            return Mapper.Map<IEnumerable<Endereco>, IEnumerable<EnderecoViewModel>>(endereco);
        }

        public IEnumerable<EnderecoViewModel> ObterEnderecoPorFornecedor(int idFornecedor)
        {
            var endereco = _enderecoService.ObterEnderecoPorCliente(idFornecedor);
            return Mapper.Map<IEnumerable<Endereco>, IEnumerable<EnderecoViewModel>>(endereco);
        }

        public void Dispose()
        {
            _enderecoService.Dispose();
        }

        public EnderecoViewModel GetById(int id)
        {
            return Mapper.Map<Endereco, EnderecoViewModel>(_enderecoService.GetById(id));
        }

        public void Add(ClienteEnderecoViewModel clienteEndereco)
        {
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEndereco);
            _enderecoService.Add(endereco);
            _enderecoService.SaveChanges();
            clienteEndereco.EnderecoId = endereco.EnderecoId;
        }

        public void Update(ClienteEnderecoViewModel clienteEndereco)
        {
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEndereco);
            _enderecoService.Update(endereco);
            _enderecoService.SaveChanges();
        }
    }
}
 