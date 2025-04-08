namespace SmsMost.Database;

/// <summary />
public enum MessageStatus
{
    /// <summary>
    /// Message has been queued for delivery.
    /// </summary>
    Queued = 1,

    /// <summary>
    /// Message is scheduled for future delivery.
    /// </summary>
    Scheduled,

    /// <summary>
    /// Message has been sent.
    /// </summary>
    Sent,

    /// <summary />
    Failed,

    /// <summary />
    Bounced,
}