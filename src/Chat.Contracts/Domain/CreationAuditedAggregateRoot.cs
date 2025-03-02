using Chat.Contracts.Domain.Interfaces;

namespace Chat.Contracts.Domain;

[Serializable]
public abstract class CreationAuditedAggregateRoot : AggregateRoot, ICreationAuditedObject
{
    public virtual DateTime CreationTime { get; protected set; }
    
    public virtual Guid? CreatorId { get; protected set; }
}

[Serializable]
public abstract class CreationAuditedAggregateRoot<TKey> : AggregateRoot<TKey>, ICreationAuditedObject
{
    public virtual DateTime CreationTime { get; set; }
    
    public virtual Guid? CreatorId { get; set; }

    protected CreationAuditedAggregateRoot()
    {

    }

    protected CreationAuditedAggregateRoot(TKey id)
        : base(id)
    {

    }
}
