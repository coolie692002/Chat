namespace Chat.Contracts.Domain.Interfaces;

public interface IHasConcurrencyStamp
{
    string ConcurrencyStamp { get; set; }
}
