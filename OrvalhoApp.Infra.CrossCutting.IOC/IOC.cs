using System;
using Microsoft.Extensions.DependencyInjection;
using OrvalhoApp.Application.Interfaces;
using OrvalhoApp.Application.Services;
using OrvalhoApp.Domain.Interfaces;
using OrvalhoApp.Infra.Data.Contexto;
using OrvalhoApp.Infra.Data.Repositories;

namespace OrvalhoApp.Infra.CrossCutting.IOC
{
    public class Ioc
    {
        public static void RegistrarDependencias(IServiceCollection services)
        {
            //services.AddSingleton<OrvalhoContext>();

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBaseApp<>), typeof(BaseApp<>));

            services.AddScoped<IUnidadeMedidaApp, UnidadeMedidaApp>();
            services.AddScoped<ICategoriaApp, CategoriaApp>();
            services.AddScoped<IProdutoApp,  ProdutoApp>();

            services.AddScoped<IUnidadeMedidaRepository, UnidadeMedidaRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProdutoRepository,  ProdutoRepository>();
            
            
        }
    }
}
