namespace SmsMost;

/// <summary>
/// SMS message.
/// </summary>
public record SmsMessage
{
    /// <summary>
    /// Message identifier.
    /// </summary>
    public required Guid Id { get; set; }

    /// <summary>
    /// Phone number, in E.164 format.
    /// </summary>
    public required string PhoneNumber { get; set; }

    /// <summary>
    /// Message.
    /// </summary>
    public required string Message { get; set; }
}