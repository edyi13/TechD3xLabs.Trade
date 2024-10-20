using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechD3xLabs.Trade.Domain.Entities;

namespace TechD3xLabs.Trade.Persistence.Seeders
{
    public class OrderSeeder : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
            new Order
            {
                Id = 1,
                Symbol = "META",
                Side = Domain.Enums.OrderSide.BUY,
                TransactTime = DateTime.Now,
                Quantity = 1000,
                Type = Domain.Enums.OrderType.LIMIT,
                Price = 522.99M,
                Currency = "USD",
                Text = "",
                Created = DateTime.Now,
                CreatedBy = "system"
            },
            new Order
            {
                Id = 2,
                Symbol = "MSFT",
                Side = Domain.Enums.OrderSide.BUY,
                TransactTime = DateTime.Now,
                Quantity = 300,
                Type = Domain.Enums.OrderType.LIMIT,
                Price = 424.30M,
                Currency = "USD",
                Text = "",
                Created = DateTime.Now,
                CreatedBy = "system"
            },
            new Order
            {
                Id = 3,
                Symbol = "AMZN",
                Side = Domain.Enums.OrderSide.SELL,
                TransactTime = DateTime.Now,
                Quantity = 400,
                Type = Domain.Enums.OrderType.MARKET,
                Price = 0,
                Currency = "USD",
                Text = "",
                Created = DateTime.Now,
                CreatedBy = "system"
            },
            new Order
            {
                Id = 4,
                Symbol = "TSLA",
                Side = Domain.Enums.OrderSide.SELL,
                TransactTime = DateTime.Now,
                Quantity = 800,
                Type = Domain.Enums.OrderType.MARKET,
                Price = 0,
                Currency = "USD",
                Text = "",
                Created = DateTime.Now,
                CreatedBy = "system"
            });
        }
    }
}
