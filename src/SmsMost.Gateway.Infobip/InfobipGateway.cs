using Infobip.Api.Client;
using Infobip.Api.Client.Api;
using Infobip.Api.Client.Model;
using Microsoft.Extensions.Options;
using InfobipbSmsMessage = Infobip.Api.Client.Model.SmsMessage;

namespace SmsMost.Gateway.Infobip;

/// <summary />
public class InfobipGateway : IGateway
{
    private readonly InfobipOptions _options;


    /// <summary />
    public InfobipGateway( IOptionsSnapshot<InfobipOptions> options )
    {
        _options = options.Value;
    }


    /// <inheritdoc />
    public async Task<SmsReceipt> SmsSendAsync( SmsMessage message, CancellationToken cancellationToken )
    {
        var smsApi = new SmsApi( new Configuration()
        {
            BasePath = _options.BasePath,
            ApiKey = _options.ApiKey,
        } );


        /*
         * 
         */
        var messages = new List<InfobipbSmsMessage>( 1 );
        messages.Add( new InfobipbSmsMessage()
        {
            Content = new SmsMessageContent( new SmsTextContent( message.Message ) ),
            Destinations = [ new SmsDestination( to: message.PhoneNumber, messageId: message.Id.ToString() ) ],
            Options = new SmsMessageOptions() { },
            Webhooks = new SmsWebhooks() { },
        } );


        /*
         * 
         */
        var req = new SmsRequest( messages, new SmsMessageRequestOptions()
        {
        } );

        var resp = await smsApi.SendSmsMessagesAsync( req, cancellationToken );

        var status = resp.Messages.First().Status;
        var messageId = resp.Messages.First().MessageId;


        /*
         * 
         */


        /*
         * 
         */
        return new SmsReceipt()
        {
            GwMessageId = messageId,
        };
    }
}