using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;
using Users;
using static Users.Users;

using var channel = GrpcChannel.ForAddress("https://localhost:7140");

var client = new UsersClient(channel);

Console.WriteLine("Unary");


var reply = await client.GetUserAsync(
                  new UserRequest { Id = 1 });
Console.WriteLine("Greeting: " + reply.Name);

AsyncClientStreamingCall<User, Empty> clientStreamingCall = await ClinetStream(client);

AsyncServerStreamingCall<User> serverStreamCall = await ServerStream(client);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();

static async Task<AsyncClientStreamingCall<User, Empty>> ClinetStream(UsersClient client)
{
    var random = Random.Shared;
    Console.WriteLine("Client Stream");
    var call = client.CreateUser();

    for (var i = 0; i < 3; i++)
    {
        var userId = random.Next(2, 100);
        var userRequest = new User { Id = userId, Name = $"user{userId}" };
        await call.RequestStream.WriteAsync(userRequest);
        Console.WriteLine($"Sending user:{userRequest.Name}");
    }

    await call.RequestStream.CompleteAsync();

    var response = await call;
    return call;
}

static async Task<AsyncServerStreamingCall<User>> ServerStream(UsersClient client)
{
    Console.WriteLine("Server Stream");
    var call2 = client.GetUsers(new Empty { });

    await foreach (var response2 in call2.ResponseStream.ReadAllAsync())
    {
        Console.WriteLine("Greeting: " + response2.Name);

    }

    return call2;
}