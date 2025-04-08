using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace SmsMost.Database;

/// <summary />
[EntityTypeConfiguration<ChannelTypeConfig, Channel>]
public class Channel
{
    /// <summary />
    [Key]
    public Guid Id { get; set; }

    /// <summary />
    [StringLength( 20 )]
    public string Code { get; set; } = default!;

    /// <summary />
    [StringLength( 50 )]
    public string Name { get; set; } = default!;

    /// <summary />
    [StringLength( 200 )]
    public string? Description { get; set; }
}


/// <summary />
public class ChannelTypeConfig : IEntityTypeConfiguration<Channel>
{
    /// <summary />
    public void Configure( EntityTypeBuilder<Channel> builder )
    {
        builder.HasIndex( x => x.Code ).IsUnique();
    }
}