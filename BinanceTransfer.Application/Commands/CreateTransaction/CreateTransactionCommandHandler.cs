using BinanceTransfer.Domain.Core;
using BinanceTransfer.Domain.Interfaces;
using MediatR;

namespace BinanceTransfer.Application.Commands.CreateTransaction;

public class CreateTransactionCommandHandler : IRequestHandler<CreateTransactionCommand, Guid>
{
    private readonly IDomainDbContext _dbContext;

    public CreateTransactionCommandHandler(IDomainDbContext dbContext) => _dbContext = dbContext;

    public async Task<Guid> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
    {
        var transaction = new Transaction()
        {
            Id = request.Id,
            CreateDate = request.CreateDate,
            NameTransaction = request.NameTransaction
        };

        await _dbContext.Transactions.AddAsync(transaction, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return transaction.Id;
    }
}