using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayrollService.Application.Features.Payrolls.Commands;
using PayrollService.Domain.Interfaces;
using PayrollService.Infrastructure.Persistence;
using PayrollService.Infrastructure.Repositories;

namespace PayrollService.Infrastructure.DependencyInjection;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PayrollDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IPayrollRepository, PayrollRepository>();

        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssemblyContaining<CreatePayrollCommand>());

        return services;
    }
}
