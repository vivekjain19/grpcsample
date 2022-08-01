using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Users;
using static Users.Users;

namespace GrpcService.Services
{
    public class UsersService : UsersBase
    {
        private readonly ILogger<UsersService> logger;

        public UsersService(ILogger<UsersService> logger)
        {
            this.logger = logger;
        }

        public override Task<User> GetUser(UserRequest request, ServerCallContext context)
        {
            return Task.FromResult<User>(UsersDB.Users.FirstOrDefault(i => i.Id == request.Id));
        }


        public async override Task<Empty> CreateUser(IAsyncStreamReader<User> requestStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext())
            {
                UsersDB.Users.Add(requestStream.Current);
            }

            return new Empty();
        }


        public async override Task GetUsers(Google.Protobuf.WellKnownTypes.Empty request, IServerStreamWriter<User> responseStream, ServerCallContext context)
        {
            foreach (var user in UsersDB.Users)
            {
                await responseStream.WriteAsync(user);
            }

            await responseStream.WriteAsync(UsersDB.Users[0]);

            await responseStream.WriteAsync(UsersDB.Users[0]);

        }
    }
}
