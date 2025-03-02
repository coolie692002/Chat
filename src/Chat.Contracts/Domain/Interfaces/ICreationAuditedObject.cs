namespace Chat.Contracts.Domain.Interfaces;

public interface ICreationAuditedObject
{
    DateTime CreationTime { get; }
    
    Guid? CreatorId { get; }
}

public interface ICreationAuditedObject<TCreator> : ICreationAuditedObject
{
    TCreator? Creator { get; }
}
