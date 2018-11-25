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
            CreateMap<ClienteViewModel, Cliente>()
                .MaxDepth(30);
            CreateMap<ClienteEnderecoViewModel, Cliente>()
                .MaxDepth(30);

            CreateMap<ClienteEnderecoViewModel, Endereco>()
             .ForMember(s => s.Fornecedor, opt => opt.Ignore())
             .MaxDepth(30);

            CreateMap<EnderecoViewModel, Endereco>()
                .MaxDepth(30);

            CreateMap<CidadeViewModel, Cidade>()
                .MaxDepth(30);
            CreateMap<EstadoViewModel, Estado>()
                .MaxDepth(30);
            CreateMap<TipoEnderecoViewModel, TipoEndereco>();
            CreateMap<FornecedorViewModel, Fornecedor>()
                .MaxDepth(30);

        }
    }
}
