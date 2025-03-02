using Ardalis.GuardClauses;
using Chat.Contracts.Domain;
using Chat.Domain.AggregatesModel.FileAggregate.Enums;
using Chat.Domain.AggregatesModel.FileAggregate.Exceptions;
using Chat.Domain.Shared;
using JetBrains.Annotations;

namespace Chat.Domain.AggregatesModel.FileAggregate.Entities;

public class File : FullAuditedAggregateRoot<Guid>
{
    public Guid? ParentId { get; protected set; }

    public string FileContainerName { get; protected set; }

    public string FileName { get; protected set; }

    public string? MimeType { get; protected set; }

    public FileType FileType { get; protected set; }

    // Số lượng tệp tin con (nếu tệp tin này là một thư mục)
    public int SubFilesQuantity { get; protected set; }

    // Cho biết tệp tin này có chứa thư mục con hay không.
    public bool HasSubdirectories { get; protected set; }

    public long ByteSize { get; protected set; }

    public string? Hash { get; protected set; }

    public string? BlobName { get; protected set; }

    public string? Flag { get; protected set; }

    /// <summary>
    /// It is used to accommodate both soft deletion and unique indexing.
    /// Initially, it is an empty string, and it is set to a random value during soft deletion.
    /// </summary>
    public string SoftDeletionToken { get; set; }

    protected File()
    {
    }

    internal File(
        Guid id,
        File? parent,
        string fileContainerName,
        string fileName,
        string? mimeType,
        FileType fileType,
        long byteSize,
        string? hash,
        string? blobName,
        string? flag = null) : base(id)
    {
        if (parent != null && parent.FileContainerName != fileContainerName)
        {
            throw new UnexpectedFileContainerNameException();
        }
        
        ParentId = parent?.Id;
        FileContainerName = fileContainerName;
        FileName = fileName;
        MimeType = mimeType;
        FileType = fileType;
        SubFilesQuantity = 0;
        HasSubdirectories = false;
        ByteSize = byteSize;
        Hash = hash;
        BlobName = blobName;
        Flag = flag;
        SoftDeletionToken = string.Empty;
    }

    internal void UpdateInfo(
        string fileName,
        string? mimeType,
        int subFilesQuantity,
        bool hasSubdirectories,
        long byteSize,
        string? hash,
        string? blobName,
        File? parent)
    {
        ParentId = parent?.Id;
        FileName = fileName;
        MimeType = mimeType;
        SubFilesQuantity = subFilesQuantity;
        HasSubdirectories = hasSubdirectories;
        ByteSize = byteSize;
        Hash = hash;
        BlobName = blobName;
    }

    public bool TryUpdateStatisticData()
    {
        return true;
    }

    public void SetFlag(string? flag)
    {
        Flag = flag;
    }

}
