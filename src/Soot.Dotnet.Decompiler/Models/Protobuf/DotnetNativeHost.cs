// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DotnetNativeHost.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Soot.Dotnet.Decompiler.Models.Protobuf {

  /// <summary>Holder for reflection information generated from DotnetNativeHost.proto</summary>
  public static partial class DotnetNativeHostReflection {

    #region Descriptor
    /// <summary>File descriptor for DotnetNativeHost.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DotnetNativeHostReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZEb3RuZXROYXRpdmVIb3N0LnByb3RvIs8CChFBbmFseXplclBhcmFtc01z",
            "ZxIxChRhbmFseXplcl9tZXRob2RfY2FsbBgBIAEoDjITLkFuYWx5emVyTWV0",
            "aG9kQ2FsbBIjChthc3NlbWJseV9maWxlX2Fic29sdXRlX3BhdGgYAiABKAkS",
            "HAoUdHlwZV9yZWZsZWN0aW9uX25hbWUYAyABKAkSEwoLbWV0aG9kX25hbWUY",
            "BCABKAkSIwoNbWV0aG9kX3BhcmFtcxgFIAMoCzIMLlNvb3RUeXBlTXNnEhUK",
            "DXByb3BlcnR5X25hbWUYBiABKAkSGgoScHJvcGVydHlfaXNfc2V0dGVyGAcg",
            "ASgIEhIKCmV2ZW50X25hbWUYCCABKAkSLwoTZXZlbnRfYWNjZXNzb3JfdHlw",
            "ZRgJIAEoDjISLkV2ZW50QWNjZXNzb3JUeXBlEhIKCmRlYnVnX21vZGUYCiAB",
            "KAgi7QEKC1Nvb3RUeXBlTXNnEh8KBGtpbmQYASABKA4yES5Tb290VHlwZU1z",
            "Zy5LaW5kEhEKCXR5cGVfbmFtZRgCIAEoCRIWCg5udW1fZGltZW5zaW9ucxgD",
            "IAEoBRIWCg5pc19jYWxsX2J5X3JlZhgEIAEoCBISCgppc19nZW5lcmljGAUg",
            "ASgIEhoKEmdlbmVyaWNfcGFyYW1ldGVycxgGIAMoCSJKCgRLaW5kEgsKB05P",
            "X0tJTkQQABINCglQUklNSVRJVkUQARIHCgNSRUYQAhIOCgpBUlJBWV9QUklN",
            "EAMSDQoJQVJSQVlfUkVGEAQqmgEKEkFuYWx5emVyTWV0aG9kQ2FsbBILCgdO",
            "T19DQUxMEAASEQoNR0VUX0FMTF9UWVBFUxABEhMKD0dFVF9NRVRIT0RfQk9E",
            "WRACEh8KG0dFVF9NRVRIT0RfQk9EWV9PRl9QUk9QRVJUWRADEhwKGEdFVF9N",
            "RVRIT0RfQk9EWV9PRl9FVkVOVBAEEhAKDEdFVF9UWVBFX0RFRhAFKmQKEUV2",
            "ZW50QWNjZXNzb3JUeXBlEhMKD05PX0VWRU5UX01FVEhPRBAAEhAKDEFERF9B",
            "Q0NFU1NPUhABEhMKD0lOVk9LRV9BQ0NFU1NPUhACEhMKD1JFTU9WRV9BQ0NF",
            "U1NPUhADQlMKEXNvb3QuZG90bmV0LnByb3RvQhVQcm90b0RvdG5ldE5hdGl2",
            "ZUhvc3SqAiZTb290LkRvdG5ldC5EZWNvbXBpbGVyLk1vZGVscy5Qcm90b2J1",
            "ZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerMethodCall), typeof(global::Soot.Dotnet.Decompiler.Models.Protobuf.EventAccessorType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerParamsMsg), global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerParamsMsg.Parser, new[]{ "AnalyzerMethodCall", "AssemblyFileAbsolutePath", "TypeReflectionName", "MethodName", "MethodParams", "PropertyName", "PropertyIsSetter", "EventName", "EventAccessorType", "DebugMode" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg), global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Parser, new[]{ "Kind", "TypeName", "NumDimensions", "IsCallByRef", "IsGeneric", "GenericParameters" }, null, new[]{ typeof(global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Types.Kind) }, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum AnalyzerMethodCall {
    [pbr::OriginalName("NO_CALL")] NoCall = 0,
    [pbr::OriginalName("GET_ALL_TYPES")] GetAllTypes = 1,
    [pbr::OriginalName("GET_METHOD_BODY")] GetMethodBody = 2,
    [pbr::OriginalName("GET_METHOD_BODY_OF_PROPERTY")] GetMethodBodyOfProperty = 3,
    [pbr::OriginalName("GET_METHOD_BODY_OF_EVENT")] GetMethodBodyOfEvent = 4,
    [pbr::OriginalName("GET_TYPE_DEF")] GetTypeDef = 5,
  }

  public enum EventAccessorType {
    [pbr::OriginalName("NO_EVENT_METHOD")] NoEventMethod = 0,
    [pbr::OriginalName("ADD_ACCESSOR")] AddAccessor = 1,
    [pbr::OriginalName("INVOKE_ACCESSOR")] InvokeAccessor = 2,
    [pbr::OriginalName("REMOVE_ACCESSOR")] RemoveAccessor = 3,
  }

  #endregion

  #region Messages
  public sealed partial class AnalyzerParamsMsg : pb::IMessage<AnalyzerParamsMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AnalyzerParamsMsg> _parser = new pb::MessageParser<AnalyzerParamsMsg>(() => new AnalyzerParamsMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AnalyzerParamsMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Soot.Dotnet.Decompiler.Models.Protobuf.DotnetNativeHostReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnalyzerParamsMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnalyzerParamsMsg(AnalyzerParamsMsg other) : this() {
      analyzerMethodCall_ = other.analyzerMethodCall_;
      assemblyFileAbsolutePath_ = other.assemblyFileAbsolutePath_;
      typeReflectionName_ = other.typeReflectionName_;
      methodName_ = other.methodName_;
      methodParams_ = other.methodParams_.Clone();
      propertyName_ = other.propertyName_;
      propertyIsSetter_ = other.propertyIsSetter_;
      eventName_ = other.eventName_;
      eventAccessorType_ = other.eventAccessorType_;
      debugMode_ = other.debugMode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnalyzerParamsMsg Clone() {
      return new AnalyzerParamsMsg(this);
    }

    /// <summary>Field number for the "analyzer_method_call" field.</summary>
    public const int AnalyzerMethodCallFieldNumber = 1;
    private global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerMethodCall analyzerMethodCall_ = global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerMethodCall.NoCall;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerMethodCall AnalyzerMethodCall {
      get { return analyzerMethodCall_; }
      set {
        analyzerMethodCall_ = value;
      }
    }

    /// <summary>Field number for the "assembly_file_absolute_path" field.</summary>
    public const int AssemblyFileAbsolutePathFieldNumber = 2;
    private string assemblyFileAbsolutePath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AssemblyFileAbsolutePath {
      get { return assemblyFileAbsolutePath_; }
      set {
        assemblyFileAbsolutePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type_reflection_name" field.</summary>
    public const int TypeReflectionNameFieldNumber = 3;
    private string typeReflectionName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TypeReflectionName {
      get { return typeReflectionName_; }
      set {
        typeReflectionName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "method_name" field.</summary>
    public const int MethodNameFieldNumber = 4;
    private string methodName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MethodName {
      get { return methodName_; }
      set {
        methodName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "method_params" field.</summary>
    public const int MethodParamsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg> _repeated_methodParams_codec
        = pb::FieldCodec.ForMessage(42, global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Parser);
    private readonly pbc::RepeatedField<global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg> methodParams_ = new pbc::RepeatedField<global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg> MethodParams {
      get { return methodParams_; }
    }

    /// <summary>Field number for the "property_name" field.</summary>
    public const int PropertyNameFieldNumber = 6;
    private string propertyName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PropertyName {
      get { return propertyName_; }
      set {
        propertyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "property_is_setter" field.</summary>
    public const int PropertyIsSetterFieldNumber = 7;
    private bool propertyIsSetter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PropertyIsSetter {
      get { return propertyIsSetter_; }
      set {
        propertyIsSetter_ = value;
      }
    }

    /// <summary>Field number for the "event_name" field.</summary>
    public const int EventNameFieldNumber = 8;
    private string eventName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EventName {
      get { return eventName_; }
      set {
        eventName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "event_accessor_type" field.</summary>
    public const int EventAccessorTypeFieldNumber = 9;
    private global::Soot.Dotnet.Decompiler.Models.Protobuf.EventAccessorType eventAccessorType_ = global::Soot.Dotnet.Decompiler.Models.Protobuf.EventAccessorType.NoEventMethod;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Soot.Dotnet.Decompiler.Models.Protobuf.EventAccessorType EventAccessorType {
      get { return eventAccessorType_; }
      set {
        eventAccessorType_ = value;
      }
    }

    /// <summary>Field number for the "debug_mode" field.</summary>
    public const int DebugModeFieldNumber = 10;
    private bool debugMode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DebugMode {
      get { return debugMode_; }
      set {
        debugMode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AnalyzerParamsMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AnalyzerParamsMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AnalyzerMethodCall != other.AnalyzerMethodCall) return false;
      if (AssemblyFileAbsolutePath != other.AssemblyFileAbsolutePath) return false;
      if (TypeReflectionName != other.TypeReflectionName) return false;
      if (MethodName != other.MethodName) return false;
      if(!methodParams_.Equals(other.methodParams_)) return false;
      if (PropertyName != other.PropertyName) return false;
      if (PropertyIsSetter != other.PropertyIsSetter) return false;
      if (EventName != other.EventName) return false;
      if (EventAccessorType != other.EventAccessorType) return false;
      if (DebugMode != other.DebugMode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AnalyzerMethodCall != global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerMethodCall.NoCall) hash ^= AnalyzerMethodCall.GetHashCode();
      if (AssemblyFileAbsolutePath.Length != 0) hash ^= AssemblyFileAbsolutePath.GetHashCode();
      if (TypeReflectionName.Length != 0) hash ^= TypeReflectionName.GetHashCode();
      if (MethodName.Length != 0) hash ^= MethodName.GetHashCode();
      hash ^= methodParams_.GetHashCode();
      if (PropertyName.Length != 0) hash ^= PropertyName.GetHashCode();
      if (PropertyIsSetter != false) hash ^= PropertyIsSetter.GetHashCode();
      if (EventName.Length != 0) hash ^= EventName.GetHashCode();
      if (EventAccessorType != global::Soot.Dotnet.Decompiler.Models.Protobuf.EventAccessorType.NoEventMethod) hash ^= EventAccessorType.GetHashCode();
      if (DebugMode != false) hash ^= DebugMode.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (AnalyzerMethodCall != global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerMethodCall.NoCall) {
        output.WriteRawTag(8);
        output.WriteEnum((int) AnalyzerMethodCall);
      }
      if (AssemblyFileAbsolutePath.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssemblyFileAbsolutePath);
      }
      if (TypeReflectionName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TypeReflectionName);
      }
      if (MethodName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(MethodName);
      }
      methodParams_.WriteTo(output, _repeated_methodParams_codec);
      if (PropertyName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PropertyName);
      }
      if (PropertyIsSetter != false) {
        output.WriteRawTag(56);
        output.WriteBool(PropertyIsSetter);
      }
      if (EventName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(EventName);
      }
      if (EventAccessorType != global::Soot.Dotnet.Decompiler.Models.Protobuf.EventAccessorType.NoEventMethod) {
        output.WriteRawTag(72);
        output.WriteEnum((int) EventAccessorType);
      }
      if (DebugMode != false) {
        output.WriteRawTag(80);
        output.WriteBool(DebugMode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (AnalyzerMethodCall != global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerMethodCall.NoCall) {
        output.WriteRawTag(8);
        output.WriteEnum((int) AnalyzerMethodCall);
      }
      if (AssemblyFileAbsolutePath.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssemblyFileAbsolutePath);
      }
      if (TypeReflectionName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TypeReflectionName);
      }
      if (MethodName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(MethodName);
      }
      methodParams_.WriteTo(ref output, _repeated_methodParams_codec);
      if (PropertyName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PropertyName);
      }
      if (PropertyIsSetter != false) {
        output.WriteRawTag(56);
        output.WriteBool(PropertyIsSetter);
      }
      if (EventName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(EventName);
      }
      if (EventAccessorType != global::Soot.Dotnet.Decompiler.Models.Protobuf.EventAccessorType.NoEventMethod) {
        output.WriteRawTag(72);
        output.WriteEnum((int) EventAccessorType);
      }
      if (DebugMode != false) {
        output.WriteRawTag(80);
        output.WriteBool(DebugMode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AnalyzerMethodCall != global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerMethodCall.NoCall) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AnalyzerMethodCall);
      }
      if (AssemblyFileAbsolutePath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssemblyFileAbsolutePath);
      }
      if (TypeReflectionName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TypeReflectionName);
      }
      if (MethodName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MethodName);
      }
      size += methodParams_.CalculateSize(_repeated_methodParams_codec);
      if (PropertyName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PropertyName);
      }
      if (PropertyIsSetter != false) {
        size += 1 + 1;
      }
      if (EventName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EventName);
      }
      if (EventAccessorType != global::Soot.Dotnet.Decompiler.Models.Protobuf.EventAccessorType.NoEventMethod) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EventAccessorType);
      }
      if (DebugMode != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AnalyzerParamsMsg other) {
      if (other == null) {
        return;
      }
      if (other.AnalyzerMethodCall != global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerMethodCall.NoCall) {
        AnalyzerMethodCall = other.AnalyzerMethodCall;
      }
      if (other.AssemblyFileAbsolutePath.Length != 0) {
        AssemblyFileAbsolutePath = other.AssemblyFileAbsolutePath;
      }
      if (other.TypeReflectionName.Length != 0) {
        TypeReflectionName = other.TypeReflectionName;
      }
      if (other.MethodName.Length != 0) {
        MethodName = other.MethodName;
      }
      methodParams_.Add(other.methodParams_);
      if (other.PropertyName.Length != 0) {
        PropertyName = other.PropertyName;
      }
      if (other.PropertyIsSetter != false) {
        PropertyIsSetter = other.PropertyIsSetter;
      }
      if (other.EventName.Length != 0) {
        EventName = other.EventName;
      }
      if (other.EventAccessorType != global::Soot.Dotnet.Decompiler.Models.Protobuf.EventAccessorType.NoEventMethod) {
        EventAccessorType = other.EventAccessorType;
      }
      if (other.DebugMode != false) {
        DebugMode = other.DebugMode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            AnalyzerMethodCall = (global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerMethodCall) input.ReadEnum();
            break;
          }
          case 18: {
            AssemblyFileAbsolutePath = input.ReadString();
            break;
          }
          case 26: {
            TypeReflectionName = input.ReadString();
            break;
          }
          case 34: {
            MethodName = input.ReadString();
            break;
          }
          case 42: {
            methodParams_.AddEntriesFrom(input, _repeated_methodParams_codec);
            break;
          }
          case 50: {
            PropertyName = input.ReadString();
            break;
          }
          case 56: {
            PropertyIsSetter = input.ReadBool();
            break;
          }
          case 66: {
            EventName = input.ReadString();
            break;
          }
          case 72: {
            EventAccessorType = (global::Soot.Dotnet.Decompiler.Models.Protobuf.EventAccessorType) input.ReadEnum();
            break;
          }
          case 80: {
            DebugMode = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            AnalyzerMethodCall = (global::Soot.Dotnet.Decompiler.Models.Protobuf.AnalyzerMethodCall) input.ReadEnum();
            break;
          }
          case 18: {
            AssemblyFileAbsolutePath = input.ReadString();
            break;
          }
          case 26: {
            TypeReflectionName = input.ReadString();
            break;
          }
          case 34: {
            MethodName = input.ReadString();
            break;
          }
          case 42: {
            methodParams_.AddEntriesFrom(ref input, _repeated_methodParams_codec);
            break;
          }
          case 50: {
            PropertyName = input.ReadString();
            break;
          }
          case 56: {
            PropertyIsSetter = input.ReadBool();
            break;
          }
          case 66: {
            EventName = input.ReadString();
            break;
          }
          case 72: {
            EventAccessorType = (global::Soot.Dotnet.Decompiler.Models.Protobuf.EventAccessorType) input.ReadEnum();
            break;
          }
          case 80: {
            DebugMode = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SootTypeMsg : pb::IMessage<SootTypeMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SootTypeMsg> _parser = new pb::MessageParser<SootTypeMsg>(() => new SootTypeMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SootTypeMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Soot.Dotnet.Decompiler.Models.Protobuf.DotnetNativeHostReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SootTypeMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SootTypeMsg(SootTypeMsg other) : this() {
      kind_ = other.kind_;
      typeName_ = other.typeName_;
      numDimensions_ = other.numDimensions_;
      isCallByRef_ = other.isCallByRef_;
      isGeneric_ = other.isGeneric_;
      genericParameters_ = other.genericParameters_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SootTypeMsg Clone() {
      return new SootTypeMsg(this);
    }

    /// <summary>Field number for the "kind" field.</summary>
    public const int KindFieldNumber = 1;
    private global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Types.Kind kind_ = global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Types.Kind.NoKind;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Types.Kind Kind {
      get { return kind_; }
      set {
        kind_ = value;
      }
    }

    /// <summary>Field number for the "type_name" field.</summary>
    public const int TypeNameFieldNumber = 2;
    private string typeName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TypeName {
      get { return typeName_; }
      set {
        typeName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "num_dimensions" field.</summary>
    public const int NumDimensionsFieldNumber = 3;
    private int numDimensions_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumDimensions {
      get { return numDimensions_; }
      set {
        numDimensions_ = value;
      }
    }

    /// <summary>Field number for the "is_call_by_ref" field.</summary>
    public const int IsCallByRefFieldNumber = 4;
    private bool isCallByRef_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsCallByRef {
      get { return isCallByRef_; }
      set {
        isCallByRef_ = value;
      }
    }

    /// <summary>Field number for the "is_generic" field.</summary>
    public const int IsGenericFieldNumber = 5;
    private bool isGeneric_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsGeneric {
      get { return isGeneric_; }
      set {
        isGeneric_ = value;
      }
    }

    /// <summary>Field number for the "generic_parameters" field.</summary>
    public const int GenericParametersFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _repeated_genericParameters_codec
        = pb::FieldCodec.ForString(50);
    private readonly pbc::RepeatedField<string> genericParameters_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> GenericParameters {
      get { return genericParameters_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SootTypeMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SootTypeMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Kind != other.Kind) return false;
      if (TypeName != other.TypeName) return false;
      if (NumDimensions != other.NumDimensions) return false;
      if (IsCallByRef != other.IsCallByRef) return false;
      if (IsGeneric != other.IsGeneric) return false;
      if(!genericParameters_.Equals(other.genericParameters_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Kind != global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Types.Kind.NoKind) hash ^= Kind.GetHashCode();
      if (TypeName.Length != 0) hash ^= TypeName.GetHashCode();
      if (NumDimensions != 0) hash ^= NumDimensions.GetHashCode();
      if (IsCallByRef != false) hash ^= IsCallByRef.GetHashCode();
      if (IsGeneric != false) hash ^= IsGeneric.GetHashCode();
      hash ^= genericParameters_.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Kind != global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Types.Kind.NoKind) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Kind);
      }
      if (TypeName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TypeName);
      }
      if (NumDimensions != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(NumDimensions);
      }
      if (IsCallByRef != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsCallByRef);
      }
      if (IsGeneric != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsGeneric);
      }
      genericParameters_.WriteTo(output, _repeated_genericParameters_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Kind != global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Types.Kind.NoKind) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Kind);
      }
      if (TypeName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TypeName);
      }
      if (NumDimensions != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(NumDimensions);
      }
      if (IsCallByRef != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsCallByRef);
      }
      if (IsGeneric != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsGeneric);
      }
      genericParameters_.WriteTo(ref output, _repeated_genericParameters_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Kind != global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Types.Kind.NoKind) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Kind);
      }
      if (TypeName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TypeName);
      }
      if (NumDimensions != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumDimensions);
      }
      if (IsCallByRef != false) {
        size += 1 + 1;
      }
      if (IsGeneric != false) {
        size += 1 + 1;
      }
      size += genericParameters_.CalculateSize(_repeated_genericParameters_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SootTypeMsg other) {
      if (other == null) {
        return;
      }
      if (other.Kind != global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Types.Kind.NoKind) {
        Kind = other.Kind;
      }
      if (other.TypeName.Length != 0) {
        TypeName = other.TypeName;
      }
      if (other.NumDimensions != 0) {
        NumDimensions = other.NumDimensions;
      }
      if (other.IsCallByRef != false) {
        IsCallByRef = other.IsCallByRef;
      }
      if (other.IsGeneric != false) {
        IsGeneric = other.IsGeneric;
      }
      genericParameters_.Add(other.genericParameters_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Kind = (global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Types.Kind) input.ReadEnum();
            break;
          }
          case 18: {
            TypeName = input.ReadString();
            break;
          }
          case 24: {
            NumDimensions = input.ReadInt32();
            break;
          }
          case 32: {
            IsCallByRef = input.ReadBool();
            break;
          }
          case 40: {
            IsGeneric = input.ReadBool();
            break;
          }
          case 50: {
            genericParameters_.AddEntriesFrom(input, _repeated_genericParameters_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Kind = (global::Soot.Dotnet.Decompiler.Models.Protobuf.SootTypeMsg.Types.Kind) input.ReadEnum();
            break;
          }
          case 18: {
            TypeName = input.ReadString();
            break;
          }
          case 24: {
            NumDimensions = input.ReadInt32();
            break;
          }
          case 32: {
            IsCallByRef = input.ReadBool();
            break;
          }
          case 40: {
            IsGeneric = input.ReadBool();
            break;
          }
          case 50: {
            genericParameters_.AddEntriesFrom(ref input, _repeated_genericParameters_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the SootTypeMsg message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Kind {
        [pbr::OriginalName("NO_KIND")] NoKind = 0,
        [pbr::OriginalName("PRIMITIVE")] Primitive = 1,
        [pbr::OriginalName("REF")] Ref = 2,
        [pbr::OriginalName("ARRAY_PRIM")] ArrayPrim = 3,
        [pbr::OriginalName("ARRAY_REF")] ArrayRef = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
