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
    public Guid Id { get; set; }
}


/// <summary />
public class AppUserTypeConfig : IEntityTypeConfiguration<AppUser>
{
    /// <summary />
    public void Configure( EntityTypeBuilder<AppUser> builder )
    {
    }
}