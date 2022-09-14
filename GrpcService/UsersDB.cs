using Users;

namespace GrpcService
{
    public static class UsersDB
    {
        public static List<User> Users = new()
        {
            new User { Id = 1, Name = "Alpha" },
            new User { Id = 2, Name = "Beta" },
            new User { Id = 3, Name = "Gamma" },
        };
    }
}
