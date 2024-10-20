using TechD3xLabs.Trade.Domain.Commons;
using TechD3xLabs.Trade.Domain.Enums;

namespace TechD3xLabs.Trade.Domain.Events
{
    public class OrderUpdatedEvent: BaseEvent
    {
        public string Id { get; set; }
        public string Symbol { get; set; }
        public OrderSide Side { get; set; }
        public DateTime TransactTime { get; set; }
        public int Quanty { get; set; }
        public OrderType Type { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string? Text { get; set; }
    }
}
