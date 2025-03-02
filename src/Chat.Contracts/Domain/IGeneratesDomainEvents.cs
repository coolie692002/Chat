namespace Chat.Contracts.Domain;

public interface IGeneratesDomainEvents
{
    public void RegisterDomainEvent(DomainEventRecord record);

    public void RemoveDomainEvent(DomainEventRecord record);

    public void ClearDomainEvents();
}
