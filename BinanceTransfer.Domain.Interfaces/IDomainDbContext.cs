using BinanceTransfer.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace BinanceTransfer.Domain.Interfaces;

public interface IDomainDbContext
{
    DbSet<Transaction> Transactions { get; set; }
    
    DbSet<Card> Cards { get; set; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}