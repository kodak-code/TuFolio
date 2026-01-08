using DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBContext;
using DAL.Repositorios.Contrato;
using DAL.Repositorios;
using Utility;
using BLL.Servicios.Contrato;
using BLL.Servicios;

namespace IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TufolioContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("cadenaSQL"));
            });

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddScoped<IRolService, RolService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}
