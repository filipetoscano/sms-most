using Microsoft.Extensions.Logging;
using SmsMost.Database;

namespace SmsMost.Services.Messages;

/// <summary />
public partial class MessageServices
{
    private readonly MostDb _db;
    private readonly ILogger<MessageServices> _logger;


    /// <summary />
    public MessageServices( MostDb db, ILogger<MessageServices> logger )
    {
        _db = db;
        _logger = logger;
    }
}