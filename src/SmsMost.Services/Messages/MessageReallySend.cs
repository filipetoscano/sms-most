using Microsoft.EntityFrameworkCore;
using SmsMost.Database;
using SmsMost.Gateway.Null;

namespace SmsMost.Services.Messages;

public partial class MessageServices
{
    /// <summary />
    public async Task<MessageReallySendResponse> MessageReallySendAsync( MessageReallySendRequest request, CancellationToken cancellationToken )
    {
        /*
         * 
         */
        var rec = await _db
            .Messages
            .Include( x => x.Channel )
            .Where( x => x.Id == request.MessageId )
            .SingleOrDefaultAsync();

        if ( rec == null )
            throw new Exception();


        /*
         * TODO: Determine which gateway based on channel
         */
        IGateway gateway = new NullGateway( default! );

        var receipt = await gateway.SmsSendAsync( new SmsMessage()
        {
            Id = request.MessageId,
            Message = rec.Text,
            PhoneNumber = rec.PhoneNumber,
        }, cancellationToken );


        /*
         * 
         */
        rec.Status = MessageStatus.Sent;
        rec.MomentUpdated = DateTimeOffset.UtcNow;

        await _db.SaveChangesAsync();


        /*
         * 
         */
        return new MessageReallySendResponse();
    }
}


/// <summary />
public record MessageReallySendRequest
{
    /// <summary />
    public required Guid MessageId { get; set; }
}


/// <summary />
public record MessageReallySendResponse
{
}