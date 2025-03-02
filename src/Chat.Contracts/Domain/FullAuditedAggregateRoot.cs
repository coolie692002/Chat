using Chat.Contracts.Domain.Interfaces;

namespace Chat.Contracts.Domain;

[Serializable]
public abstract class FullAuditedAggregateRoot : AuditedAggregateRoot, IFullAuditedObject
{
    public virtual bool IsDeleted { get; set; }

    public virtual Guid? DeleterId { get; set; }
    
    public virtual DateTime? DeletionTime { get; set; }
    
    public void Delete()
    {
        IsDeleted = true;
    }
}

/// <summary>
/// Implements <see cref="IFullAuditedObject"/> to be a base class for full-audited aggregate roots.
/// </summary>
/// <typeparam name="TKey">Type of the primary key of the entity</typeparam>
[Serializable]
public abstract class FullAuditedAggregateRoot<TKey> : AuditedAggregateRoot<TKey>, IFullAuditedObject
{
    public virtual bool IsDeleted { get; set; }
    
    public virtual Guid? DeleterId { get; set; }
    
    public virtual DateTime? DeletionTime { get; set; }

    public void Delete()
    {
        IsDeleted = true;
    }
    
    protected FullAuditedAggregateRoot()
    {

    }

    protected FullAuditedAggregateRoot(TKey id)
        : base(id)
    {

    }
}
