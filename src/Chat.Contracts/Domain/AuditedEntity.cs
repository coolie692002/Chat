using Chat.Contracts.Domain.Interfaces;

namespace Chat.Contracts.Domain;

[Serializable]
public abstract class AuditedEntity : CreationAuditedEntity, IAuditedObject
{
    public virtual DateTime? LastModificationTime { get; set; }
    
    public virtual Guid? LastModifierId { get; set; }
}

[Serializable]
public abstract class AuditedEntity<TKey> : CreationAuditedEntity<TKey>, IAuditedObject
{
    public virtual DateTime? LastModificationTime { get; set; }
    
    public virtual Guid? LastModifierId { get; set; }

    protected AuditedEntity()
    {

    }

    protected AuditedEntity(TKey id)
        : base(id)
    {

    }
}
