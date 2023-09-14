﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoModeloDDD.Infra.Data.Contextos;

namespace ProjetoModeloDDD.Infra.CrossCutting.IoC
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(configuration.GetConnectionString("sqlConnection"), builder =>
                builder.MigrationsAssembly("ProjetoModeloDDD.Infra.Data")));
    }
}
