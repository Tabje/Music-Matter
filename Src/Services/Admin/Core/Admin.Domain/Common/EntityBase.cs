using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Domain.Common
{
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
        public DateTime CreatedDateUtc { get; protected set; } = DateTime.UtcNow;
        public DateTime? ModifiedDateUtc { get; set; }

        private List<DomainEventBase> _domainEvents = new();
        [NotMapped]
        public IEnumerable<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

        protected void RegisterDomainEvent(DomainEventBase domainEvent) => _domainEvents.Add(domainEvent);
        internal void ClearDomainEvents() => _domainEvents.Clear();
    }
}
