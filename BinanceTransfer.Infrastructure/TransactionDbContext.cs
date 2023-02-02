using BinanceTransfer.Domain.Core;
using BinanceTransfer.Domain.Interfaces;
using BinanceTransfer.Infrastructure.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace BinanceTransfer.Infrastructure;
sealed class TransactionDbContext : DbContext, ITransactionDbContext
{
    public DbSet<Transaction> Transactions { get; set; }

    public TransactionDbContext(DbContextOptions<TransactionDbContext> options) :
        base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TransactionConfiguration());
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await SaveChangesAsync();
    }
}
