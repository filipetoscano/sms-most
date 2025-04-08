using Microsoft.Extensions.Logging;
using SmsMost.Database;

namespace SmsMost.Services.Users;

/// <summary />
public partial class UserServices
{
    private readonly MostDb _db;
    private readonly ILogger<UserServices> _logger;


    /// <summary />
    public UserServices( MostDb db, ILogger<UserServices> logger )
    {
        _db = db;
        _logger = logger;
    }
}