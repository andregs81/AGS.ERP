using AGS.ERP.Application.Validation;
using AGS.ERP.Domain.ValueObjects;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Application.AutoMapper
{
    public class DomainToApplicationMappingProfile : Profile
    {
        public DomainToApplicationMappingProfile()
        {
            CreateMap<ValidationError, ValidationAppError>();
            CreateMap<ValidationResult, ValidationAppResult>();
        }
    }
}
