namespace SmsMost.Web;

/// <summary />
public class Program
{
    /// <summary />
    public static void Main( string[] args )
    {
        /*
         * 
         */
        var builder = WebApplication.CreateBuilder( args );

        builder.Services.AddRazorPages();


        /*
         * 
         */
        var app = builder.Build();

        if ( app.Environment.IsDevelopment() == false )
        {
            app.UseExceptionHandler( "/error" );
            //app.UseHsts();
        }

        //app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.MapStaticAssets();

        app.MapRazorPages()
           .WithStaticAssets();


        /*
         * 
         */
        app.Run();
    }
}