using JWT_Minimal_API.Services;
using Serilog;

namespace JWT_Minimal_API.Routes
{
    public static class UserClamins
    {

        public static void MapClaimRoutes(this IEndpointRouteBuilder app)
        {
            app.MapGet("/user",
 (HttpContext httpContext, IUserService service) =>
 {

     var userInfo = service.GetUserClaims(httpContext);

     if (userInfo is not null)
     {
         return Results.Ok(userInfo);
     }

     return Results.BadRequest();

 });

        }
    }
}





