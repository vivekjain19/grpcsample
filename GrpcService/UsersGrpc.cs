// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/users.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Users {
  public static partial class Users
  {
    static readonly string __ServiceName = "users.Users";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Users.UserRequest> __Marshaller_users_UserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Users.UserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Users.User> __Marshaller_users_User = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Users.User.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Users.UserRequest, global::Users.User> __Method_GetUser = new grpc::Method<global::Users.UserRequest, global::Users.User>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUser",
        __Marshaller_users_UserRequest,
        __Marshaller_users_User);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Users.User, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateUser = new grpc::Method<global::Users.User, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "CreateUser",
        __Marshaller_users_User,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Users.User> __Method_GetUsers = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Users.User>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetUsers",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_users_User);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Users.UsersReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Users</summary>
    [grpc::BindServiceMethod(typeof(Users), "BindService")]
    public abstract partial class UsersBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Users.User> GetUser(global::Users.UserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateUser(grpc::IAsyncStreamReader<global::Users.User> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GetUsers(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::IServerStreamWriter<global::Users.User> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(UsersBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetUser, serviceImpl.GetUser)
          .AddMethod(__Method_CreateUser, serviceImpl.CreateUser)
          .AddMethod(__Method_GetUsers, serviceImpl.GetUsers).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UsersBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Users.UserRequest, global::Users.User>(serviceImpl.GetUser));
      serviceBinder.AddMethod(__Method_CreateUser, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Users.User, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateUser));
      serviceBinder.AddMethod(__Method_GetUsers, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Users.User>(serviceImpl.GetUsers));
    }

  }
}
#endregion
