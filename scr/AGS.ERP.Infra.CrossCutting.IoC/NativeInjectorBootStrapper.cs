using AGS.ERP.Application.Interfaces;
using AGS.ERP.Application.Services;
using AGS.ERP.Domain.Interfaces.Repository;
using AGS.ERP.Domain.Interfaces.Services;
using AGS.ERP.Domain.Service;
using AGS.ERP.Infra.Data.Context;
using AGS.ERP.Infra.Data.Repository;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            //Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<IEstadoAppService, EstadoAppService>();
            services.AddScoped<ICidadeAppService, CidadeAppService>();
            services.AddScoped<IFornecedorAppService, FornecedorAppService>();


            //Domain Services
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IEstadoService, EstadoService>();
            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<IFornecedorService, FornecedorService>();



            //data repo
            services.AddScoped<AgsErpContext>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IEstadoRepository, EstadoRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
        }
    }
}
