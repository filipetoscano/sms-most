using Microsoft.Extensions.Logging;
using SmsMost.Database;

namespace SmsMost.Services.Templates;

/// <summary />
public partial class TemplateServices
{
    private readonly MostDb _db;
    private readonly ILogger<TemplateServices> _logger;


    /// <summary />
    public TemplateServices( MostDb db, ILogger<TemplateServices> logger )
    {
        _db = db;
        _logger = logger;
    }
}