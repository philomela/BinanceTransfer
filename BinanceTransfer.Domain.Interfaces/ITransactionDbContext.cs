using BinanceTransfer.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace BinanceTransfer.Domain.Interfaces;

public interface ITransactionDbContext
{
    DbSet<Transaction> Transactions { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}