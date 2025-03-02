namespace Chat.Contracts.Domain.Interfaces;

public interface IAggregateRoot : IEntity
{

}

/// <summary>
/// Defines an aggregate root with a single primary key with "Id" property.
/// </summary>
/// <typeparam name="TKey">Type of the primary key of the entity</typeparam>
public interface IAggregateRoot<TKey> : IEntity<TKey>, IAggregateRoot
{

}
