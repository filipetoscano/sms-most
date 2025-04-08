namespace SmsMost;

/// <summary />
public interface IGateway
{
    /// <summary />
    Task<SmsReceipt> SmsSendAsync( SmsMessage message, CancellationToken cancellationToken );
}