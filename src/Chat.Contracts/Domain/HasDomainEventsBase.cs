using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Chat.Contracts.Domain;

public abstract class HasDomainEventsBase
{
    private readonly List<DomainEventRecord> _domainEvents = [];

    [NotMapped, JsonIgnore]
    public IReadOnlyCollection<DomainEventRecord> DomainEvents => _domainEvents.AsReadOnly();

    public void RegisterDomainEvent(DomainEventRecord record)
    {
        _domainEvents.Add(record);
    }

    public void RemoveDomainEvent(DomainEventRecord record)
    {
        _domainEvents.Remove(record);
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}
