using AGS.ERP.Application.ViewModel;
using AGS.ERP.Domain.Entities;
using AGS.ERP.Domain.Entities.Geografia;
using AutoMapper;

namespace AGS.ERP.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteEnderecoViewModel, Cliente>();
            CreateMap<ClienteEnderecoViewModel, Endereco>();

            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<CidadeViewModel, Cidade>();
            CreateMap<EstadoViewModel, Estado>();
            CreateMap<TipoEnderecoViewModel, TipoEndereco>();
        }
    }
}
