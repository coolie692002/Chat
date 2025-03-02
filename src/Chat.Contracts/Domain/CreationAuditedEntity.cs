using Chat.Contracts.Domain.Interfaces;

namespace Chat.Contracts.Domain;

[Serializable]
public abstract class CreationAuditedEntity : Entity, ICreationAuditedObject
{
    public virtual DateTime CreationTime { get; protected set; }
    
    public virtual Guid? CreatorId { get; protected set; }
}

[Serializable]
public abstract class CreationAuditedEntity<TKey> : Entity<TKey>, ICreationAuditedObject
{
    public virtual DateTime CreationTime { get; protected set; }

    public virtual Guid? CreatorId { get; protected set; }

    protected CreationAuditedEntity()
    {

    }

    protected CreationAuditedEntity(TKey id)
        : base(id)
    {

    }
}
