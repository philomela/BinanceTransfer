using BinanceTransfer.Domain.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BinanceTransfer.Infrastructure.EntityTypeConfigurations;

public class CardConfiguration : IEntityTypeConfiguration<Card> 
{
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BankName);
            builder.Property(x => x.CardNumber);
            builder.Property(x => x.CardOwner);
            builder.Property(x => x.PaymentSystem);
            builder.Property(x => x.ValidTo);
        }
}
