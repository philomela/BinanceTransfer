using BinanceTransfer.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BinanceTransfer.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration["DbConnection"];
        
        services.AddDbContext<TransactionDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
        services.AddScoped<ITransactionDbContext>(provider => provider.GetService<TransactionDbContext>());

        return services;
    }
}