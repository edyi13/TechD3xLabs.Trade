using TechD3xLabs.Trade.Domain.Commons;

namespace TechD3xLabs.Trade.Domain.Events
{
    public class OrderCanceledEvent : BaseEvent
    {
        public int Id { get; set; }
    }
}
