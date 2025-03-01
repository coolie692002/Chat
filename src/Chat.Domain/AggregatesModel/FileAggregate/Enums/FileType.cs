namespace Chat.Domain.AggregatesModel.FileAggregate.Enums;

[Flags]
public enum FileType
{
    Directory = 1,
    RegularFile = 2
}
