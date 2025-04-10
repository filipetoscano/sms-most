using Infobip.Api.Client.Api;
using Infobip.Api.Client;
using Microsoft.Extensions.Options;

namespace SmsMost.Gateway.Infobip;

/// <summary />
public class InfobipGateway : IGateway
{
    private readonly InfobipOptions _options;


    /// <summary />
    public InfobipGateway( IOptionsSnapshot<InfobipOptions> options )
    {
        _options = options.Value;
    }


    /// <inheritdoc />
    public Task<SmsReceipt> SmsSendAsync( SmsMessage message, CancellationToken cancellationToken )
    {
        var smsApi = new SmsApi( new Configuration()
        {
            BasePath= _options.BasePath,
            ApiKey = _options.ApiKey,
        } );
    }
}