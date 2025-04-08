using Microsoft.EntityFrameworkCore;
using SmsMost.Database;

namespace SmsMost.Services.Templates;

public partial class MessageServices
{
    /// <summary />
    public async Task<TemplateCreateResponse> TemplateCreateAsync( TemplateCreateRequest request )
    {
        await Task.Delay( 100 );

        throw new NotImplementedException();
    }
}


/// <summary />
public record TemplateCreateRequest
{
}


/// <summary />
public record TemplateCreateResponse
{
}