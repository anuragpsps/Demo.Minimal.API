using JWT_Minimal_API.Models;

namespace JWT_Minimal_API.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "admin1", EmailAddress = "test.admin@mail.com", Password = "Pa$$w0rd", GivenName = "Bart", Surname = "Tom", Role = "Administrator" },
            new() { Username = "normal1", EmailAddress = "test.anurag@mail.com", Password = "Pa$$w0rd", GivenName = "Normie", Surname = "Anurag", Role = "Pandey" },
        };
    }
}
