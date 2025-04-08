using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace SmsMost.Database;

/// <summary />
[EntityTypeConfiguration<GatewayTypeConfig, Gateway>]
public class Gateway
{
    /// <summary />
    [Key]
    public Guid Id { get; set; }

    /// <summary />
    public bool IsEnabled { get; set; }
}


/// <summary />
public class GatewayTypeConfig : IEntityTypeConfiguration<Gateway>
{
    /// <summary />
    public void Configure( EntityTypeBuilder<Gateway> builder )
    {
    }
}