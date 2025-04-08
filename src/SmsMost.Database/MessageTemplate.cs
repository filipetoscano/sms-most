using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmsMost.Database;

/// <summary />
[EntityTypeConfiguration<MessageTemplateTypeConfig, MessageTemplate>]
public class MessageTemplate
{
    /// <summary />
    [Key]
    public Guid Id { get; set; }

    /// <summary />
    public Guid ChannelId { get; set; }

    /// <summary />
    [StringLength( 20 )]
    public string Code { get; set; } = default!;

    /// <summary />
    [StringLength( 50 )]
    public string Name { get; set; } = default!;

    /// <summary />
    [StringLength( 200 )]
    public string? Description { get; set; }

    /// <summary />
    public string Config { get; set; } = default!;


    /// <summary />
    [ForeignKey( nameof( ChannelId ) )]
    public virtual Channel Channel { get; set; } = default!;
}


/// <summary />
public class MessageTemplateTypeConfig : IEntityTypeConfiguration<MessageTemplate>
{
    /// <summary />
    public void Configure( EntityTypeBuilder<MessageTemplate> builder )
    {
        builder.HasIndex( x => new
        {
            x.ChannelId,
            x.Code,
        } ).IsUnique();
    }
}