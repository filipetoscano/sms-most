using Microsoft.Extensions.Options;

namespace SmsMost.Gateway.SmsGatewayApiEU;

/// <summary />
public class SmsGatewayApiGateway : IGateway
{
    private readonly SmsGatewayApiOptions _options;


    /// <summary />
    public SmsGatewayApiGateway( IOptionsSnapshot<SmsGatewayApiOptions> options )
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