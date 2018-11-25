using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Interfaces.Repository;
using AGS.ERP.Domain.Interfaces.Services;
using AGS.ERP.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Domain.Service
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) 
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public ValidationResult AddCliente(Cliente cliente)
        {
            var resultadoValidacao = new ValidationResult();

            if (!cliente.IsValid())
            {
                resultadoValidacao.AdicionarErro(cliente.ResultadoValidacao);
                return resultadoValidacao;
            }

            base.Add(cliente);

            return resultadoValidacao;
        }

        public Cliente ClienteCompleto(int id)
        {
            return _clienteRepository.ClienteCompleto(id);
        }
    }
}
