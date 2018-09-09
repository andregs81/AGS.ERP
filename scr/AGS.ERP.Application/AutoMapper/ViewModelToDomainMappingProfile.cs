using AGS.ERP.Application.ViewModel;
using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Entities.Geografia;
using AutoMapper;
using System.Collections.Generic;

namespace AGS.ERP.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ClienteEnderecoViewModel, Cliente>();

            CreateMap<ClienteEnderecoViewModel, Endereco>()
             .ForMember(s => s.Fornecedor, opt => opt.Ignore());

            CreateMap<EnderecoViewModel, Endereco>();

            CreateMap<CidadeViewModel, Cidade>();
            CreateMap<EstadoViewModel, Estado>();
            CreateMap<TipoEnderecoViewModel, TipoEndereco>();
            CreateMap<FornecedorViewModel, Fornecedor>();

        }
    }
}
