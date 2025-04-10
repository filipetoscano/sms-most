using Microsoft.Extensions.Options;

namespace SmsMost.Gateway.Plivo;

/// <summary />
public class PlivoGateway : IGateway
{
    private readonly PlivoOptions _options;


    /// <summary />
    public PlivoGateway( IOptionsSnapshot<PlivoOptions> options )
    {
        _options = options.Value;
    }


    /// <inheritdoc />
    public Task<SmsReceipt> SmsSendAsync( SmsMessage message, CancellationToken cancellationToken )
    {
        throw new NotImplementedException();
    }
}