using TechD3xLabs.Trade.Domain.Commons;
using TechD3xLabs.Trade.Domain.Enums;

namespace TechD3xLabs.Trade.Domain.Entities
{
    public class Order: BaseAuditableEntity
    {
        public  string Symbol { get; set; }
        public OrderSide Side { get; set; }
        public DateTime TransactTime { get; set; }
        public int Quantity { get; set; }
        public OrderType Type { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string? Text { get; set; }
    }
}
