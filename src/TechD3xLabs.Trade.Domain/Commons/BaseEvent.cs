﻿namespace TechD3xLabs.Trade.Domain.Commons
{
    public abstract class BaseEvent
    {
        public Guid MessageId { get; set; }
        public DateTime PublishTime { get; set; }
    }
}
