using Chat.Contracts.Domain.Interfaces;

namespace Chat.Contracts.Domain;

[Serializable]
public abstract class FullAuditedEntity : AuditedEntity, IFullAuditedObject
{
    public virtual bool IsDeleted { get; set; }
    
    public virtual Guid? DeleterId { get; set; }
    
    public virtual DateTime? DeletionTime { get; set; }
    
    public void Delete() => IsDeleted = true;
}

[Serializable]
public abstract class FullAuditedEntity<TKey> : AuditedEntity<TKey>, IFullAuditedObject
{
    public virtual bool IsDeleted { get; set; }

    public virtual Guid? DeleterId { get; set; }

    public virtual DateTime? DeletionTime { get; set; }

    public void Delete() => IsDeleted = true;
    
    protected FullAuditedEntity()
    {

    }

    protected FullAuditedEntity(TKey id)
        : base(id)
    {

    }
}
