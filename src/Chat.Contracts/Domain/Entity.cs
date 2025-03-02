using Chat.Contracts.Domain.Interfaces;

namespace Chat.Contracts.Domain;

[Serializable]
public abstract class Entity : IEntity
{
    protected Entity()
    {
        
    }
    public override string ToString()
    {
        return $"";
    }

    public abstract object?[] GetKeys();
    
}


[Serializable]
public abstract class Entity<TKey> : Entity, IEntity<TKey>
{
    public virtual TKey Id { get; protected set; } = default!;

    protected Entity()
    {

    }

    protected Entity(TKey id)
    {
        Id = id;
    }

    public override object?[] GetKeys()
    {
        return [Id];
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"[ENTITY: {GetType().Name}] Id = {Id}";
    }
}
