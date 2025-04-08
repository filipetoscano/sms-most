using Microsoft.Extensions.Options;

namespace SmsMost.Gateway.GatewayApi;

/// <summary />
public class GatewayApiGateway : IGateway
{
    private readonly GatewayApiOptions _options;


    /// <summary />
    public GatewayApiGateway( IOptionsSnapshot<GatewayApiOptions> options )
    {
        _options = options.Value;
    }


    /// <inheritdoc />
    public async Task<SmsReceipt> SmsSendAsync( SmsMessage message, CancellationToken cancellationToken )
    {
        await Task.Delay( 0 );

        throw new NotImplementedException();
    }
}