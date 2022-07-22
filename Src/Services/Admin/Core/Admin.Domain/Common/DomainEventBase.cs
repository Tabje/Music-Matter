using MediatR;

namespace Admin.Domain.Common
{
    public abstract class DomainEventBase : INotification
    {
        public DateTime DateOccurredUtc { get; protected set; } = DateTime.UtcNow;
    }
}
