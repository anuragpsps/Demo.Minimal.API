using Microsoft.EntityFrameworkCore;
using Minimal.Database;
using Minimal.Model;

namespace JWT_Minimal_API.Routes
{
    public static class Students
    {

        public static void MapStudentRoutes(this IEndpointRouteBuilder app)
        {
            app.MapGet("/GetAllStudent", async (MyDataContext db) =>
            await db.Students.ToListAsync());

           
            app.MapPost("/SaveStudent", async (Student student, MyDataContext db) =>
            {
                db.Students.Add(student);
                await db.SaveChangesAsync();

                return Results.Created($"/save/{student.Id}", student);
            });

            app.MapPut("/UpdateStudents/{id}", async (int id, Student studentinput, MyDataContext db) =>
            {
                var student = await db.Students.FindAsync(id);

                if (student is null) return Results.NotFound();

                student.Name = studentinput.Name;
                student.Phone = studentinput.Phone;

                await db.SaveChangesAsync();

                return Results.NoContent();
            });



        }
    }
}
