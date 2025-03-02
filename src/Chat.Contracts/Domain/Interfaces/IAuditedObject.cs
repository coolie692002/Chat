namespace Chat.Contracts.Domain.Interfaces;

public interface IAuditedObject : ICreationAuditedObject, IModificationAuditedObject
{

}

public interface IAuditedObject<TUser> : IAuditedObject, ICreationAuditedObject<TUser>, IModificationAuditedObject<TUser>
{

}
