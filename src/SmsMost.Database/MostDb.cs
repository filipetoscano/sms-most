using Microsoft.EntityFrameworkCore;

namespace SmsMost.Database;

/// <summary />
public class MostDb : DbContext
{
    /// <summary />
    public MostDb( DbContextOptions<MostDb> options )
        : base( options )
    {
    }


    /// <summary />
    public DbSet<AppUser> AppUsers { get; set; }

    /// <summary />
    public DbSet<Channel> Channels { get; set; }

    /// <summary />
    public DbSet<Gateway> Gateways { get; set; }

    /// <summary />
    public DbSet<Message> Messages { get; set; }

    /// <summary />
    public DbSet<MessageTemplate> MessageTemplates { get; set; }

    /// <summary />
    public DbSet<MessageTemplateLocale> MessageTemplateLocales { get; set; }



    /// <inheritdoc />
    protected override void OnConfiguring( DbContextOptionsBuilder options )
    {
    }


    /// <summary />
    public Guid NewId()
    {
        // TODO: Depends on provider

        return Guid.NewGuid();
    }
}