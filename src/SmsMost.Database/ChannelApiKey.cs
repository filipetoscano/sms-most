using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmsMost.Database;

/// <summary />
[EntityTypeConfiguration<ChannelApiKeyTypeConfig, ChannelApiKey>]
public class ChannelApiKey
{
    /// <summary />
    [Key]
    public required Guid Id { get; set; }

    /// <summary />
    public required Guid ChannelId { get; set; }

    /// <summary />
    public required string ApiKey { get; set; }

    /// <summary />
    public required string Name { get; set; }

    /// <summary />
    public required DateTimeOffset MomentCreated { get; set; }

    /// <summary />
    public required DateTimeOffset MomentUpdated { get; set; }


    /// <summary />
    [ForeignKey( nameof( ChannelId ) )]
    public virtual Channel Channel { get; set; } = default!;
}


/// <summary />
public class ChannelApiKeyTypeConfig : IEntityTypeConfiguration<ChannelApiKey>
{
    /// <summary />
    public void Configure( EntityTypeBuilder<ChannelApiKey> builder )
    {
        builder.HasIndex( x => x.ApiKey ).IsUnique();
    }
}