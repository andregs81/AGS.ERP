using AGS.ERP.Application.ViewModel;
using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Entities.Geografia;
using AutoMapper;
using System.Collections.Generic;

namespace AGS.ERP.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>()
                //.ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Endereco));
                .ForMember(dest => dest.Endereco, opt => opt.Ignore());




            CreateMap<Cliente, ClienteEnderecoViewModel>()
                .ForMember(dest => dest.Endereco, opt => opt.Ignore())
                .ForMember(dest => dest.Estado, opt => opt.Ignore())
                .ForMember(dest => dest.Fornecedor, opt => opt.Ignore());


            CreateMap<Endereco, ClienteEnderecoViewModel>()
                .ForMember(dest => dest.Fornecedor, opt => opt.Ignore())
                .ForMember(dest => dest.Estado, opt => opt.Ignore());


            CreateMap<Endereco, EnderecoViewModel>()
                .MaxDepth(30);
            CreateMap<Cidade, CidadeViewModel>()
                .MaxDepth(30);
            CreateMap<Estado, EstadoViewModel>()
                .MaxDepth(30);
            CreateMap<TipoEndereco, TipoEnderecoViewModel>();
            CreateMap<Fornecedor, FornecedorViewModel>()
                .MaxDepth(30);
        }
    }
}
