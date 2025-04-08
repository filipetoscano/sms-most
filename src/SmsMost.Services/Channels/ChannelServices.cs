using Microsoft.Extensions.Logging;
using SmsMost.Database;

namespace SmsMost.Services.Channels;

/// <summary />
public partial class ChannelServices
{
    private readonly MostDb _db;
    private readonly ILogger<ChannelServices> _logger;


    /// <summary />
    public ChannelServices( MostDb db, ILogger<ChannelServices> logger )
    {
        _db = db;
        _logger = logger;
    }
}