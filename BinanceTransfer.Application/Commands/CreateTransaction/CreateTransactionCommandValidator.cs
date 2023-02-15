using FluentValidation;

namespace BinanceTransfer.Application.Commands.CreateTransaction;

public class CreateTransactionCommandValidator: AbstractValidator<CreateTransactionCommand>
{
    public CreateTransactionCommandValidator()
    {
        RuleFor(command => command.CreateDate)
            .Must(x => x.HasValue ? x.Value >= DateTime.Now : false)
            .WithMessage("DateTime in CreateTransaction not valid");
    }
}