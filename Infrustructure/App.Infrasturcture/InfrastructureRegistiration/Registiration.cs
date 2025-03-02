using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Persistence.Context;
using App.Persistence.Repositories;
using App.Persistence.RepositoryConcrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.Persistence.InfrastructureRegistiration
{
    public static class Registiration
    {
        public static IServiceCollection AddRepository(this IServiceCollection services,IConfiguration congfiguration)
        {
            ConnectionStringOption connectionStrings = congfiguration.GetSection(ConnectionStringOption.key).Get<ConnectionStringOption>();
            services.AddDbContext<RentCarContext>(options =>
            {
                options.UseSqlServer(connectionStrings!.SqlServer,sqlServerOptionsAction =>
                {
                    sqlServerOptionsAction.MigrationsAssembly(typeof(InfrastructureAssembly).Assembly.FullName);
                });
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<ICarPricingRepository, CarPricingRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ITagCloudRepository, TagCloudRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();

            return services;
        }
    }
}
