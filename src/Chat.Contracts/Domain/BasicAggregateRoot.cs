using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Chat.Contracts.Domain.Interfaces;

namespace Chat.Contracts.Domain;


[Serializable]
public abstract class BasicAggregateRoot : Entity, IAggregateRoot, IGeneratesDomainEvents
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

[Serializable]
public abstract class BasicAggregateRoot<TKey> : Entity<TKey>, IAggregateRoot<TKey>, IGeneratesDomainEvents
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
    
    protected BasicAggregateRoot()
    {

    }

    protected BasicAggregateRoot(TKey id)
        : base(id)
    {

    }
}

