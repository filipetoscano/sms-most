using Microsoft.Extensions.Logging;

namespace SmsMost.Gateway.Null;

/// <summary />
public class NullGateway : IGateway
{
    private readonly ILogger<NullGateway> _logger;


    /// <summary />
    public NullGateway( ILogger<NullGateway> logger )
    {
        _logger = logger;
    }


    /// <summary />
    public async Task<SmsReceipt> SmsSendAsync( SmsMessage message, CancellationToken cancellationToken = default )
    {
        _logger.LogInformation( "To {PhoneNumber}: {Message}", message.PhoneNumber, message.Message );

        await Task.Delay( 100 );

        return new SmsReceipt()
        {
            GwMessageId = Guid.NewGuid().ToString(),
        };
    }
}