using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmsMost.Database;

/// <summary />
[EntityTypeConfiguration<MessageTemplateLocaleTypeConfig, MessageTemplateLocale>]
public class MessageTemplateLocale
{
    /// <summary />
    [Key]
    public Guid Id { get; set; }

    /// <summary />
    public Guid TemplateId { get; set; }

    /// <summary />
    [StringLength( 10 ), Unicode( false )]
    public string Lang { get; set; } = default!;

    /// <summary />
    [StringLength( 500 )]
    public string Text { get; set; } = default!;


    /// <summary />
    [ForeignKey( nameof( TemplateId ) )]
    public virtual MessageTemplate Template { get; set; } = default!;
}


/// <summary />
public class MessageTemplateLocaleTypeConfig : IEntityTypeConfiguration<MessageTemplateLocale>
{
    /// <summary />
    public void Configure( EntityTypeBuilder<MessageTemplateLocale> builder )
    {
    }
}