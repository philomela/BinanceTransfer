using MediatR;

namespace BinanceTransfer.Application.Commands.CreateTransaction;

public class CreateTransactionCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public DateTime? CreateDate { get; set; }
}