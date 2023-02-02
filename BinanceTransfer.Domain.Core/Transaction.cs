namespace BinanceTransfer.Domain.Core;

public class Transaction
{
    public Guid Id { get; set; }

    public DateTime? CreateDate { get; set; }

    public string NameTransaction { get; set; }      
}