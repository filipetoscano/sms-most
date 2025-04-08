using Microsoft.Extensions.Logging;
using SmsMost.Database;

namespace SmsMost.Services.PhoneNumbers;

/// <summary />
public partial class PhoneNumberServices
{
    private readonly MostDb _db;
    private readonly ILogger<PhoneNumberServices> _logger;


    /// <summary />
    public PhoneNumberServices( MostDb db, ILogger<PhoneNumberServices> logger )
    {
        _db = db;
        _logger = logger;
    }
}