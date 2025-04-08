using Microsoft.EntityFrameworkCore;
using SmsMost.Database;

namespace SmsMost.Services.Messages;

public partial class MessageServices
{
    /// <summary />
    public async Task<MessageSendResponse> MessageSendAsync( MessageSendRequest request )
    {
        /*
         * 
         */
        var channelRec = await _db.Channels
            .AsNoTracking()
            .Where( x => x.Code == request.Channel )
            .Select( x => new
            {
                ChannelId = x.Id,
            } )
            .SingleOrDefaultAsync();

        var templateRec = await _db.MessageTemplateLocales
            .AsNoTracking()
            .Include( x => x.TemplateId )
            .Where( x => x.Lang == request.Lang )
            .Where( x => x.Template.Code == request.Template )
            .Select( x => new
            {
                TemplateId = x.Template.Id,
                x.Template.Config,
                x.Text,
            } )
            .SingleOrDefaultAsync();

        if ( channelRec == null )
            throw new Exception();

        if ( templateRec == null )
            throw new Exception();


        /*
         * Template formatting
         * TODO:
         */
        var text = "";


        /*
         * 
         */
        var rec = new Message()
        {
            Id = _db.NewId(),
            ChannelId = channelRec.ChannelId,
            TemplateId = templateRec.TemplateId,
            Lang = request.Lang,
            ExternalId = request.ExternalId,
            UserId = request.UserId,
            PhoneNumber = request.PhoneNumber,
            Text = text,
            Status = MessageStatus.Queued,
            MomentCreated = DateTime.UtcNow,
            MomentUpdated = DateTime.UtcNow,
        };

        _db.Messages.Add( rec );

        await _db.SaveChangesAsync();


        /*
         * Queue
         */

        // TODO


        /*
         * 
         */
        return new MessageSendResponse()
        {
            MessageId = rec.Id,
        };
    }
}


/// <summary />
public record MessageSendRequest
{
    /// <summary />
    public required string Channel { get; set; }

    /// <summary />
    public required string Template { get; set; }

    /// <summary />
    public required string Lang { get; set; }

    /// <summary />
    public string? ExternalId { get; set; }

    /// <summary />
    public string? UserId { get; set; }


    /// <summary />
    public required string PhoneNumber { get; set; }

    /// <summary />
    public required Dictionary<string, object> Values { get; set; }
}


/// <summary />
public record MessageSendResponse
{
    /// <summary />
    public required Guid MessageId { get; set; }
}