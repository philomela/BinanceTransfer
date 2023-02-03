using BinanceTransfer.Domain.Core;
using BinanceTransfer.Domain.Interfaces;
using BinanceTransfer.Infrastructure.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace BinanceTransfer.Infrastructure;
sealed class DomainDbContext : DbContext, IDomainDbContext
{
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Card> Cards { get; set; }

    public DomainDbContext(DbContextOptions<DomainDbContext> options) :
        base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TransactionConfiguration());
        modelBuilder.ApplyConfiguration(new CardConfiguration());
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await SaveChangesAsync();
    }
}
