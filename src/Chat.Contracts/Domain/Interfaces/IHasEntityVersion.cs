namespace Chat.Contracts.Domain.Interfaces;

public interface IHasEntityVersion
{
    Guid EntityVersion { get; }
}
