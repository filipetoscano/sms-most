using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace SmsMost.Database;

/// <summary />
[EntityTypeConfiguration<AppUserTypeConfig, AppUser>]
public class AppUser
{
    /// <summary />
    [Key]
    public required Guid Id { get; set; }

    /// <summary />
    [StringLength( 200  )]
    public required string Username { get; set; }
}


/// <summary />
public class AppUserTypeConfig : IEntityTypeConfiguration<AppUser>
{
    /// <summary />
    public void Configure( EntityTypeBuilder<AppUser> builder )
    {
        builder.HasIndex( x => x.Username ).IsUnique();
    }
}