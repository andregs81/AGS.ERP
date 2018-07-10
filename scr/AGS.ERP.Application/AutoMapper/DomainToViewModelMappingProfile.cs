using AGS.ERP.Application.ViewModel;
using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Entities.Geografia;
using AutoMapper;

namespace AGS.ERP.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>()
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Endereco));
                

            CreateMap<Cliente, ClienteEnderecoViewModel>();
            CreateMap<Endereco, ClienteEnderecoViewModel>();
            

            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Cidade, CidadeViewModel>();
            CreateMap<Estado, EstadoViewModel>();
            CreateMap<TipoEndereco, TipoEnderecoViewModel>();
        }
    }
}
