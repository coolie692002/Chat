using System.Diagnostics.CodeAnalysis;
using Ardalis.GuardClauses;

namespace Chat.Contracts.EntityFrameworkCore.Modeling;

public class ModelBuilderConfigurationOptions
{
    [NotNull]
    public string TablePrefix {
        get => _tablePrefix;
        set {
            Guard.Against.Null(value, nameof(value), $"{nameof(TablePrefix)} can not be null! Set to empty string if you don't want a table prefix.");
            _tablePrefix = value;
        }
    }
    
    private string _tablePrefix = null!;

    public string? Schema { get; set; }

    public ModelBuilderConfigurationOptions(
        [NotNull] string tablePrefix = "",
        string? schema = null)
    {
        Guard.Against.Null(tablePrefix, nameof(tablePrefix));

        TablePrefix = tablePrefix;
        Schema = schema;
    }
}
