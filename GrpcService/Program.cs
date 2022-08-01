using GrpcService.Services;

namespace GrpcService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Additional configuration is required to successfully run gRPC on macOS.
            // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

            // Add services to the container.
            builder.Services.AddGrpc();
            builder.Services.AddCors(o => o.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding");
            }));

            var app = builder.Build();

            app.UseRouting();
            app.UseCors();
            app.UseGrpcWeb(); // Must be added between UseRouting and UseEndpoints

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<UsersService>().EnableGrpcWeb().RequireCors("AllowAll");
            });



            app.Run();
        }
    }
}