using JWT_Minimal_API.Services;

namespace JWT_Minimal_API.Routes
{
    public static class Departments
    {

        public static void MapDepartmentRoutes(this IEndpointRouteBuilder app)
        {
            app.MapGet("/department",
 (HttpContext httpContext, IUserService service) =>
 {

     var deptinfo = service.GetDepartment();

     if (deptinfo is not null)
     {
         return Results.Ok(deptinfo);
     }

     return Results.BadRequest();

 });

        }
    }
}
