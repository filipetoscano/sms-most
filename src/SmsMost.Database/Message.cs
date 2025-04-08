using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmsMost.Database;

/// <summary />
[EntityTypeConfiguration<MessageTypeConfig, Message>]
public class Message
{
    /// <summary />
    [Key]
    public required Guid Id { get; set; }

    /// <summary />
    public required Guid ChannelId { get; set; }

    /// <summary />
    public required Guid? TemplateId { get; set; }

    /// <summary />
    [StringLength( 10 ), Unicode( false )]
    public required string? Lang { get; set; }

    /// <summary />
    [StringLength( 50 )]
    public required string? ExternalId { get; set; }

    /// <summary />
    [StringLength( 50 )]
    public required string? UserId { get; set; }

    /// <summary />
    [StringLength( 30 )]
    public required string PhoneNumber { get; set; }

    /// <summary />
    [StringLength( 500 )]
    public required string Text { get; set; }

    /// <summary />
    [StringLength( 50 ), Unicode( false )]
    public required MessageStatus Status { get; set; }

    /// <summary />
    public required DateTimeOffset MomentCreated { get; set; }

    /// <summary />
    public required DateTimeOffset MomentUpdated { get; set; }


    /// <summary />
    [ForeignKey( nameof( ChannelId ) )]
    public virtual Channel Channel { get; set; } = default!;

    /// <summary />
    [ForeignKey( nameof( TemplateId ) )]
    public virtual MessageTemplate? Template { get; set; }
}


/// <summary />
public class MessageTypeConfig : IEntityTypeConfiguration<Message>
{
    /// <summary />
    public void Configure( EntityTypeBuilder<Message> builder )
    {
        builder.Property( x => x.Status ).HasConversion<string>();
    }
}