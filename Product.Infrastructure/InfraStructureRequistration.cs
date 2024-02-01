using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Product.Core.Interface;
using Product.Core.Services;
using Product.Infrastructure.Repository;

namespace Product.Infrastructure
{
    public static class InfraStructureRequistration
    {
        public static IServiceCollection    InfraStructureConfiguration (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(IGenericRepository<>));
            //services.AddScoped<ICategoryRepository, CategoryRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();

            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        
            return services;
        }
    }
}
