using Microsoft.Extensions.Options;

namespace SmsMost.Gateway.SmsGatewayApiEU;

/// <summary />
public class SmsGatewayApiEuGateway : IGateway
{
    private readonly SmsGatewayApiEuOptions _options;


    /// <summary />
    public SmsGatewayApiEuGateway( IOptionsSnapshot<SmsGatewayApiEuOptions> options )
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