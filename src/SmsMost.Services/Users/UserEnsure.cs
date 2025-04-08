using Microsoft.EntityFrameworkCore;
using SmsMost.Database;

namespace SmsMost.Services.Users;

public partial class UserServices
{
    /// <summary />
    public async Task<UserEnsureResponse> UserEnsureAsync( UserEnsureRequest request )
    {
        var rec = await _db.AppUsers
            .Where( x => x.Username == request.Username )
            .SingleOrDefaultAsync();

        if ( rec != null )
        {
            return new UserEnsureResponse()
            {
                UserId = rec.Id
            };
        }


        /*
         * 
         */
        rec = new AppUser()
        {
            Id = _db.NewId(),
            Username = request.Username,
        };

        _db.AppUsers.Add( rec );

        await _db.SaveChangesAsync();


        /*
         * 
         */
        return new UserEnsureResponse()
        {
            UserId = rec.Id
        };
    }
}


/// <summary />
public record UserEnsureRequest
{
    /// <summary />
    public required string Username { get; set; }
}


/// <summary />
public record UserEnsureResponse
{
    /// <summary />
    public required Guid UserId { get; set; }
}