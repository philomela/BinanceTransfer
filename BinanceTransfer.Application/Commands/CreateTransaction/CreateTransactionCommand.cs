using MediatR;

namespace BinanceTransfer.Application.Commands.CreateTransaction;

public class CreateTransactionCommand : IRequest<Guid>
{
    public CreateTransactionCommand(DateTime createDateTime, string nameTransaction)
    {
        Id = Guid.NewGuid();
        CreateDate = createDateTime;
        NameTransaction = nameTransaction;
    }
    public Guid Id { get; set; }
    public DateTime? CreateDate { get; set; }
    public string NameTransaction { get; set; }
}