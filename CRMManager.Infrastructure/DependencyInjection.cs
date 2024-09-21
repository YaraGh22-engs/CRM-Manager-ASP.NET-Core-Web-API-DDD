using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using CRMManager.Infrastructure.Persistence;
using CRMManager.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {

            services.AddDbContext<CRMManagerContext>(options => options.UseSqlServer("Server=DESKTOP-407GCNR\\SQL2022;User Id=sa;Password=Ghadeer22@@;DataBase=CRM;TrustServerCertificate=True;"));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
