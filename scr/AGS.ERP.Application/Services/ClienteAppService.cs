using AGS.ERP.Application.Interfaces;
using AGS.ERP.Application.Validation;
using AGS.ERP.Application.ViewModel;
using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Domain.Interfaces.Services;
using AutoMapper;
using System.Collections.Generic;

namespace AGS.ERP.Application.Services
{
    public class ClienteAppService : AppServiceBase, IClienteAppService
    {
        private readonly IClienteService _clienteService;
        private readonly IEnderecoService _enderecoService;

        public ClienteAppService(
            IClienteService clienteService,
            IEnderecoService enderecoService
            )
        {
            _clienteService = clienteService;
            _enderecoService = enderecoService;
        }
        public ValidationAppResult Add(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(clienteEnderecoViewModel);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnderecoViewModel);

            cliente.Endereco.Add(endereco);

            var result = _clienteService.AddCliente(cliente);
            if (!result.IsValid)
                return DomainToApplicationResult(result);

            _enderecoService.Add(endereco);

            _clienteService.SaveChanges();

            return DomainToApplicationResult(result);
        }


        public ClienteViewModel GetById(int id)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.GetById(id));
        }


        public IEnumerable<ClienteViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteService.GetAll());
        }


        public IEnumerable<ClienteViewModel> ObterClientesGrid(int page, string pesquisa)
        {
            throw new System.NotImplementedException();
        }

        public int ObterTotalRegistros(string pesquisa)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
           _clienteService.Remove(id);
            _clienteService.SaveChanges();
        }

        public void Update(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);

            _clienteService.Update(cliente);
            _clienteService.SaveChanges();
        }

        public void Dispose()
        {
            _clienteService.Dispose();
        }
    }
}
