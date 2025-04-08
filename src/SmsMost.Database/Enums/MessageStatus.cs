namespace SmsMost.Database;

/// <summary />
public enum MessageStatus
{
    /// <summary />
    Queued = 1,

    /// <summary />
    Sent,

    /// <summary />
    Failed,

    /// <summary />
    Bounced,
}