namespace BinanceTransfer.Domain.Core;

public class Card
{
    public Guid Id { get; set; }

    public string BankName { get; set; }

    public string CardNumber { get; set; }

    public string CardOwner { get; set; }

    public DateTime? ValidTo { get; set; }

    public string PaymentSystem { get; set; }
}   