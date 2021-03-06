// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Messages/p4/p4_service_unit.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace P4TLB.MasterServer {
  public static partial class P4UnitService
  {
    static readonly string __ServiceName = "P4TLB.MasterServer.P4UnitService";

    static readonly grpc::Marshaller<global::P4TLB.MasterServer.UnitServiceGetPendingEventRequest> __Marshaller_P4TLB_MasterServer_UnitServiceGetPendingEventRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::P4TLB.MasterServer.UnitServiceGetPendingEventRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::P4TLB.MasterServer.UnitServiceGetPendingEventResponse> __Marshaller_P4TLB_MasterServer_UnitServiceGetPendingEventResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::P4TLB.MasterServer.UnitServiceGetPendingEventResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::P4TLB.MasterServer.CheckExistsRequest> __Marshaller_P4TLB_MasterServer_CheckExistsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::P4TLB.MasterServer.CheckExistsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::P4TLB.MasterServer.CheckExistsResponse> __Marshaller_P4TLB_MasterServer_CheckExistsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::P4TLB.MasterServer.CheckExistsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::P4TLB.MasterServer.GetUnitDataRequest> __Marshaller_P4TLB_MasterServer_GetUnitDataRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::P4TLB.MasterServer.GetUnitDataRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::P4TLB.MasterServer.GetUnitDataResponse> __Marshaller_P4TLB_MasterServer_GetUnitDataResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::P4TLB.MasterServer.GetUnitDataResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::P4TLB.MasterServer.UnitServiceGetPendingEventRequest, global::P4TLB.MasterServer.UnitServiceGetPendingEventResponse> __Method_GetPendingEvents = new grpc::Method<global::P4TLB.MasterServer.UnitServiceGetPendingEventRequest, global::P4TLB.MasterServer.UnitServiceGetPendingEventResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPendingEvents",
        __Marshaller_P4TLB_MasterServer_UnitServiceGetPendingEventRequest,
        __Marshaller_P4TLB_MasterServer_UnitServiceGetPendingEventResponse);

    static readonly grpc::Method<global::P4TLB.MasterServer.CheckExistsRequest, global::P4TLB.MasterServer.CheckExistsResponse> __Method_UnitExists = new grpc::Method<global::P4TLB.MasterServer.CheckExistsRequest, global::P4TLB.MasterServer.CheckExistsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UnitExists",
        __Marshaller_P4TLB_MasterServer_CheckExistsRequest,
        __Marshaller_P4TLB_MasterServer_CheckExistsResponse);

    static readonly grpc::Method<global::P4TLB.MasterServer.GetUnitDataRequest, global::P4TLB.MasterServer.GetUnitDataResponse> __Method_GetUnitData = new grpc::Method<global::P4TLB.MasterServer.GetUnitDataRequest, global::P4TLB.MasterServer.GetUnitDataResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUnitData",
        __Marshaller_P4TLB_MasterServer_GetUnitDataRequest,
        __Marshaller_P4TLB_MasterServer_GetUnitDataResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::P4TLB.MasterServer.P4ServiceUnitReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of P4UnitService</summary>
    [grpc::BindServiceMethod(typeof(P4UnitService), "BindService")]
    public abstract partial class P4UnitServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::P4TLB.MasterServer.UnitServiceGetPendingEventResponse> GetPendingEvents(global::P4TLB.MasterServer.UnitServiceGetPendingEventRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::P4TLB.MasterServer.CheckExistsResponse> UnitExists(global::P4TLB.MasterServer.CheckExistsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::P4TLB.MasterServer.GetUnitDataResponse> GetUnitData(global::P4TLB.MasterServer.GetUnitDataRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for P4UnitService</summary>
    public partial class P4UnitServiceClient : grpc::ClientBase<P4UnitServiceClient>
    {
      /// <summary>Creates a new client for P4UnitService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public P4UnitServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for P4UnitService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public P4UnitServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected P4UnitServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected P4UnitServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::P4TLB.MasterServer.UnitServiceGetPendingEventResponse GetPendingEvents(global::P4TLB.MasterServer.UnitServiceGetPendingEventRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPendingEvents(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::P4TLB.MasterServer.UnitServiceGetPendingEventResponse GetPendingEvents(global::P4TLB.MasterServer.UnitServiceGetPendingEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPendingEvents, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::P4TLB.MasterServer.UnitServiceGetPendingEventResponse> GetPendingEventsAsync(global::P4TLB.MasterServer.UnitServiceGetPendingEventRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPendingEventsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::P4TLB.MasterServer.UnitServiceGetPendingEventResponse> GetPendingEventsAsync(global::P4TLB.MasterServer.UnitServiceGetPendingEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPendingEvents, null, options, request);
      }
      public virtual global::P4TLB.MasterServer.CheckExistsResponse UnitExists(global::P4TLB.MasterServer.CheckExistsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UnitExists(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::P4TLB.MasterServer.CheckExistsResponse UnitExists(global::P4TLB.MasterServer.CheckExistsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UnitExists, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::P4TLB.MasterServer.CheckExistsResponse> UnitExistsAsync(global::P4TLB.MasterServer.CheckExistsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UnitExistsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::P4TLB.MasterServer.CheckExistsResponse> UnitExistsAsync(global::P4TLB.MasterServer.CheckExistsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UnitExists, null, options, request);
      }
      public virtual global::P4TLB.MasterServer.GetUnitDataResponse GetUnitData(global::P4TLB.MasterServer.GetUnitDataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUnitData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::P4TLB.MasterServer.GetUnitDataResponse GetUnitData(global::P4TLB.MasterServer.GetUnitDataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUnitData, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::P4TLB.MasterServer.GetUnitDataResponse> GetUnitDataAsync(global::P4TLB.MasterServer.GetUnitDataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUnitDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::P4TLB.MasterServer.GetUnitDataResponse> GetUnitDataAsync(global::P4TLB.MasterServer.GetUnitDataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUnitData, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override P4UnitServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new P4UnitServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(P4UnitServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetPendingEvents, serviceImpl.GetPendingEvents)
          .AddMethod(__Method_UnitExists, serviceImpl.UnitExists)
          .AddMethod(__Method_GetUnitData, serviceImpl.GetUnitData).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, P4UnitServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetPendingEvents, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::P4TLB.MasterServer.UnitServiceGetPendingEventRequest, global::P4TLB.MasterServer.UnitServiceGetPendingEventResponse>(serviceImpl.GetPendingEvents));
      serviceBinder.AddMethod(__Method_UnitExists, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::P4TLB.MasterServer.CheckExistsRequest, global::P4TLB.MasterServer.CheckExistsResponse>(serviceImpl.UnitExists));
      serviceBinder.AddMethod(__Method_GetUnitData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::P4TLB.MasterServer.GetUnitDataRequest, global::P4TLB.MasterServer.GetUnitDataResponse>(serviceImpl.GetUnitData));
    }

  }
}
#endregion
