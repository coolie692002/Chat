using System.Text.Json.Serialization;

namespace Chat.Contracts.Domain.Interfaces;

public interface ISoftDelete
{
    [JsonIgnore]
    bool IsDeleted { get; set; }

    void Delete();
}
