using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrderService.Application.Features.Orders.Commands;
using OrderService.Domain.Interfaces;
using OrderService.Infrastructure.Persistence;
using OrderService.Infrastructure.Repositories;

namespace OrderService.Infrastructure.DependencyInjection;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<OrderDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssemblyContaining<CreateOrderCommand>());

        return services;
    }
}
