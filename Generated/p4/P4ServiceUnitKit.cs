// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Messages/p4/p4_service_unit_kit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace P4TLB.MasterServer {

  /// <summary>Holder for reflection information generated from Messages/p4/p4_service_unit_kit.proto</summary>
  public static partial class P4ServiceUnitKitReflection {

    #region Descriptor
    /// <summary>File descriptor for Messages/p4/p4_service_unit_kit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static P4ServiceUnitKitReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVNZXNzYWdlcy9wNC9wNF9zZXJ2aWNlX3VuaXRfa2l0LnByb3RvEhJQNFRM",
            "Qi5NYXN0ZXJTZXJ2ZXIiIAoNR2V0S2l0UmVxdWVzdBIPCgd1bml0X2lkGAEg",
            "ASgEIpwBCg5HZXRLaXRSZXNwb25zZRI7CgVlcnJvchgBIAEoDjIsLlA0VExC",
            "Lk1hc3RlclNlcnZlci5HZXRLaXRSZXNwb25zZS5FcnJvckNvZGUSDgoGa2l0",
            "X2lkGAIgASgNEhoKEmtpdF9jdXN0b21fbmFtZV9pZBgDIAEoCSIhCglFcnJv",
            "ckNvZGUSBgoCT0sQABIMCghOb3RGb3VuZBABImIKDVNldEtpdFJlcXVlc3QS",
            "FAoMY2xpZW50X3Rva2VuGAEgASgJEg8KB3VuaXRfaWQYAiABKAQSDgoGa2l0",
            "X2lkGAMgASgNEhoKEmtpdF9jdXN0b21fbmFtZV9pZBgEIAEoCSKuAQoOU2V0",
            "S2l0UmVzcG9uc2USOwoFZXJyb3IYASABKA4yLC5QNFRMQi5NYXN0ZXJTZXJ2",
            "ZXIuU2V0S2l0UmVzcG9uc2UuRXJyb3JDb2RlIl8KCUVycm9yQ29kZRIGCgJP",
            "SxAAEhIKDkVudGl0eU5vdEZvdW5kEAESEgoOS2l0Tm90VW5sb2NrZWQQAhIQ",
            "CgxVbmF1dGhvcml6ZWQQAxIQCgxVbmtub3duRXJyb3IQBCJICglQNEtpdERh",
            "dGESDwoHdW5pdF9pZBgBIAEoBBIOCgZraXRfaWQYAiABKA0SGgoSa2l0X2N1",
            "c3RvbV9uYW1lX2lkGAMgASgJMsIBChBQNFVuaXRLaXRTZXJ2aWNlElYKDUdl",
            "dEN1cnJlbnRLaXQSIS5QNFRMQi5NYXN0ZXJTZXJ2ZXIuR2V0S2l0UmVxdWVz",
            "dBoiLlA0VExCLk1hc3RlclNlcnZlci5HZXRLaXRSZXNwb25zZRJWCg1TZXRD",
            "dXJyZW50S2l0EiEuUDRUTEIuTWFzdGVyU2VydmVyLlNldEtpdFJlcXVlc3Qa",
            "Ii5QNFRMQi5NYXN0ZXJTZXJ2ZXIuU2V0S2l0UmVzcG9uc2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::P4TLB.MasterServer.GetKitRequest), global::P4TLB.MasterServer.GetKitRequest.Parser, new[]{ "UnitId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::P4TLB.MasterServer.GetKitResponse), global::P4TLB.MasterServer.GetKitResponse.Parser, new[]{ "Error", "KitId", "KitCustomNameId" }, null, new[]{ typeof(global::P4TLB.MasterServer.GetKitResponse.Types.ErrorCode) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::P4TLB.MasterServer.SetKitRequest), global::P4TLB.MasterServer.SetKitRequest.Parser, new[]{ "ClientToken", "UnitId", "KitId", "KitCustomNameId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::P4TLB.MasterServer.SetKitResponse), global::P4TLB.MasterServer.SetKitResponse.Parser, new[]{ "Error" }, null, new[]{ typeof(global::P4TLB.MasterServer.SetKitResponse.Types.ErrorCode) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::P4TLB.MasterServer.P4KitData), global::P4TLB.MasterServer.P4KitData.Parser, new[]{ "UnitId", "KitId", "KitCustomNameId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetKitRequest : pb::IMessage<GetKitRequest> {
    private static readonly pb::MessageParser<GetKitRequest> _parser = new pb::MessageParser<GetKitRequest>(() => new GetKitRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetKitRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::P4TLB.MasterServer.P4ServiceUnitKitReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetKitRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetKitRequest(GetKitRequest other) : this() {
      unitId_ = other.unitId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetKitRequest Clone() {
      return new GetKitRequest(this);
    }

    /// <summary>Field number for the "unit_id" field.</summary>
    public const int UnitIdFieldNumber = 1;
    private ulong unitId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong UnitId {
      get { return unitId_; }
      set {
        unitId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetKitRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetKitRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnitId != other.UnitId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UnitId != 0UL) hash ^= UnitId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UnitId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(UnitId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UnitId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UnitId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetKitRequest other) {
      if (other == null) {
        return;
      }
      if (other.UnitId != 0UL) {
        UnitId = other.UnitId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            UnitId = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetKitResponse : pb::IMessage<GetKitResponse> {
    private static readonly pb::MessageParser<GetKitResponse> _parser = new pb::MessageParser<GetKitResponse>(() => new GetKitResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetKitResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::P4TLB.MasterServer.P4ServiceUnitKitReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetKitResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetKitResponse(GetKitResponse other) : this() {
      error_ = other.error_;
      kitId_ = other.kitId_;
      kitCustomNameId_ = other.kitCustomNameId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetKitResponse Clone() {
      return new GetKitResponse(this);
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 1;
    private global::P4TLB.MasterServer.GetKitResponse.Types.ErrorCode error_ = 0;
    /// <summary>
    /// The error isn't that explicit since the server doesn't check if the unit does exist or not...
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::P4TLB.MasterServer.GetKitResponse.Types.ErrorCode Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    /// <summary>Field number for the "kit_id" field.</summary>
    public const int KitIdFieldNumber = 2;
    private uint kitId_;
    /// <summary>
    /// official P4 kits...
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint KitId {
      get { return kitId_; }
      set {
        kitId_ = value;
      }
    }

    /// <summary>Field number for the "kit_custom_name_id" field.</summary>
    public const int KitCustomNameIdFieldNumber = 3;
    private string kitCustomNameId_ = "";
    /// <summary>
    /// a custom name id would only be used if 'kit_id' is set to 0 (and on masterservers that support modding...)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KitCustomNameId {
      get { return kitCustomNameId_; }
      set {
        kitCustomNameId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetKitResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetKitResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Error != other.Error) return false;
      if (KitId != other.KitId) return false;
      if (KitCustomNameId != other.KitCustomNameId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Error != 0) hash ^= Error.GetHashCode();
      if (KitId != 0) hash ^= KitId.GetHashCode();
      if (KitCustomNameId.Length != 0) hash ^= KitCustomNameId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Error != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Error);
      }
      if (KitId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KitId);
      }
      if (KitCustomNameId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(KitCustomNameId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Error != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Error);
      }
      if (KitId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KitId);
      }
      if (KitCustomNameId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KitCustomNameId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetKitResponse other) {
      if (other == null) {
        return;
      }
      if (other.Error != 0) {
        Error = other.Error;
      }
      if (other.KitId != 0) {
        KitId = other.KitId;
      }
      if (other.KitCustomNameId.Length != 0) {
        KitCustomNameId = other.KitCustomNameId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Error = (global::P4TLB.MasterServer.GetKitResponse.Types.ErrorCode) input.ReadEnum();
            break;
          }
          case 16: {
            KitId = input.ReadUInt32();
            break;
          }
          case 26: {
            KitCustomNameId = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GetKitResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum ErrorCode {
        [pbr::OriginalName("OK")] Ok = 0,
        [pbr::OriginalName("NotFound")] NotFound = 1,
      }

    }
    #endregion

  }

  public sealed partial class SetKitRequest : pb::IMessage<SetKitRequest> {
    private static readonly pb::MessageParser<SetKitRequest> _parser = new pb::MessageParser<SetKitRequest>(() => new SetKitRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetKitRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::P4TLB.MasterServer.P4ServiceUnitKitReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetKitRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetKitRequest(SetKitRequest other) : this() {
      clientToken_ = other.clientToken_;
      unitId_ = other.unitId_;
      kitId_ = other.kitId_;
      kitCustomNameId_ = other.kitCustomNameId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetKitRequest Clone() {
      return new SetKitRequest(this);
    }

    /// <summary>Field number for the "client_token" field.</summary>
    public const int ClientTokenFieldNumber = 1;
    private string clientToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientToken {
      get { return clientToken_; }
      set {
        clientToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unit_id" field.</summary>
    public const int UnitIdFieldNumber = 2;
    private ulong unitId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong UnitId {
      get { return unitId_; }
      set {
        unitId_ = value;
      }
    }

    /// <summary>Field number for the "kit_id" field.</summary>
    public const int KitIdFieldNumber = 3;
    private uint kitId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint KitId {
      get { return kitId_; }
      set {
        kitId_ = value;
      }
    }

    /// <summary>Field number for the "kit_custom_name_id" field.</summary>
    public const int KitCustomNameIdFieldNumber = 4;
    private string kitCustomNameId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KitCustomNameId {
      get { return kitCustomNameId_; }
      set {
        kitCustomNameId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetKitRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetKitRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientToken != other.ClientToken) return false;
      if (UnitId != other.UnitId) return false;
      if (KitId != other.KitId) return false;
      if (KitCustomNameId != other.KitCustomNameId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientToken.Length != 0) hash ^= ClientToken.GetHashCode();
      if (UnitId != 0UL) hash ^= UnitId.GetHashCode();
      if (KitId != 0) hash ^= KitId.GetHashCode();
      if (KitCustomNameId.Length != 0) hash ^= KitCustomNameId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ClientToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClientToken);
      }
      if (UnitId != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(UnitId);
      }
      if (KitId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(KitId);
      }
      if (KitCustomNameId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(KitCustomNameId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ClientToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientToken);
      }
      if (UnitId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UnitId);
      }
      if (KitId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KitId);
      }
      if (KitCustomNameId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KitCustomNameId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetKitRequest other) {
      if (other == null) {
        return;
      }
      if (other.ClientToken.Length != 0) {
        ClientToken = other.ClientToken;
      }
      if (other.UnitId != 0UL) {
        UnitId = other.UnitId;
      }
      if (other.KitId != 0) {
        KitId = other.KitId;
      }
      if (other.KitCustomNameId.Length != 0) {
        KitCustomNameId = other.KitCustomNameId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ClientToken = input.ReadString();
            break;
          }
          case 16: {
            UnitId = input.ReadUInt64();
            break;
          }
          case 24: {
            KitId = input.ReadUInt32();
            break;
          }
          case 34: {
            KitCustomNameId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SetKitResponse : pb::IMessage<SetKitResponse> {
    private static readonly pb::MessageParser<SetKitResponse> _parser = new pb::MessageParser<SetKitResponse>(() => new SetKitResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetKitResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::P4TLB.MasterServer.P4ServiceUnitKitReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetKitResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetKitResponse(SetKitResponse other) : this() {
      error_ = other.error_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetKitResponse Clone() {
      return new SetKitResponse(this);
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 1;
    private global::P4TLB.MasterServer.SetKitResponse.Types.ErrorCode error_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::P4TLB.MasterServer.SetKitResponse.Types.ErrorCode Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetKitResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetKitResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Error != other.Error) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Error != 0) hash ^= Error.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Error != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Error);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Error != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Error);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetKitResponse other) {
      if (other == null) {
        return;
      }
      if (other.Error != 0) {
        Error = other.Error;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Error = (global::P4TLB.MasterServer.SetKitResponse.Types.ErrorCode) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SetKitResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum ErrorCode {
        [pbr::OriginalName("OK")] Ok = 0,
        [pbr::OriginalName("EntityNotFound")] EntityNotFound = 1,
        [pbr::OriginalName("KitNotUnlocked")] KitNotUnlocked = 2,
        [pbr::OriginalName("Unauthorized")] Unauthorized = 3,
        [pbr::OriginalName("UnknownError")] UnknownError = 4,
      }

    }
    #endregion

  }

  /// <summary>
  /// Message only used on MasterServer...
  /// This msg can be freely removed and added to the DB without any risk, since Units are like entities: components holder.
  /// </summary>
  public sealed partial class P4KitData : pb::IMessage<P4KitData> {
    private static readonly pb::MessageParser<P4KitData> _parser = new pb::MessageParser<P4KitData>(() => new P4KitData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<P4KitData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::P4TLB.MasterServer.P4ServiceUnitKitReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public P4KitData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public P4KitData(P4KitData other) : this() {
      unitId_ = other.unitId_;
      kitId_ = other.kitId_;
      kitCustomNameId_ = other.kitCustomNameId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public P4KitData Clone() {
      return new P4KitData(this);
    }

    /// <summary>Field number for the "unit_id" field.</summary>
    public const int UnitIdFieldNumber = 1;
    private ulong unitId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong UnitId {
      get { return unitId_; }
      set {
        unitId_ = value;
      }
    }

    /// <summary>Field number for the "kit_id" field.</summary>
    public const int KitIdFieldNumber = 2;
    private uint kitId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint KitId {
      get { return kitId_; }
      set {
        kitId_ = value;
      }
    }

    /// <summary>Field number for the "kit_custom_name_id" field.</summary>
    public const int KitCustomNameIdFieldNumber = 3;
    private string kitCustomNameId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KitCustomNameId {
      get { return kitCustomNameId_; }
      set {
        kitCustomNameId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as P4KitData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(P4KitData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnitId != other.UnitId) return false;
      if (KitId != other.KitId) return false;
      if (KitCustomNameId != other.KitCustomNameId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UnitId != 0UL) hash ^= UnitId.GetHashCode();
      if (KitId != 0) hash ^= KitId.GetHashCode();
      if (KitCustomNameId.Length != 0) hash ^= KitCustomNameId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UnitId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(UnitId);
      }
      if (KitId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KitId);
      }
      if (KitCustomNameId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(KitCustomNameId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UnitId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UnitId);
      }
      if (KitId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KitId);
      }
      if (KitCustomNameId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KitCustomNameId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(P4KitData other) {
      if (other == null) {
        return;
      }
      if (other.UnitId != 0UL) {
        UnitId = other.UnitId;
      }
      if (other.KitId != 0) {
        KitId = other.KitId;
      }
      if (other.KitCustomNameId.Length != 0) {
        KitCustomNameId = other.KitCustomNameId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            UnitId = input.ReadUInt64();
            break;
          }
          case 16: {
            KitId = input.ReadUInt32();
            break;
          }
          case 26: {
            KitCustomNameId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code