using BinanceTransfer.Domain.Core;
using BinanceTransfer.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BinanceTransfer.Infrastructure;
sealed class TransactionDbContext : DbContext, ITransactionDbContext
{
    public DbSet<Transaction> Transactions { get; set; }

    public TransactionDbContext(DbContextOptions<TransactionDbContext> options) :
        base(options) { }

    public Task<long> SaveChangesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
