// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/core/framework/resource_handle.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/framework/resource_handle.proto</summary>
  public static partial class ResourceHandleReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/framework/resource_handle.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResourceHandleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci90ZW5zb3JmbG93L2NvcmUvZnJhbWV3b3JrL3Jlc291cmNlX2hhbmRsZS5w",
            "cm90bxIKdGVuc29yZmxvdyJyChNSZXNvdXJjZUhhbmRsZVByb3RvEg4KBmRl",
            "dmljZRgBIAEoCRIRCgljb250YWluZXIYAiABKAkSDAoEbmFtZRgDIAEoCRIR",
            "CgloYXNoX2NvZGUYBCABKAQSFwoPbWF5YmVfdHlwZV9uYW1lGAUgASgJQi8K",
            "GG9yZy50ZW5zb3JmbG93LmZyYW1ld29ya0IOUmVzb3VyY2VIYW5kbGVQAfgB",
            "AWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.ResourceHandleProto), global::Tensorflow.ResourceHandleProto.Parser, new[]{ "Device", "Container", "Name", "HashCode", "MaybeTypeName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Protocol buffer representing a handle to a tensorflow resource. Handles are
  /// not valid across executions, but can be serialized back and forth from within
  /// a single run.
  /// </summary>
  public sealed partial class ResourceHandleProto : pb::IMessage<ResourceHandleProto> {
    private static readonly pb::MessageParser<ResourceHandleProto> _parser = new pb::MessageParser<ResourceHandleProto>(() => new ResourceHandleProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResourceHandleProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.ResourceHandleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceHandleProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceHandleProto(ResourceHandleProto other) : this() {
      device_ = other.device_;
      container_ = other.container_;
      name_ = other.name_;
      hashCode_ = other.hashCode_;
      maybeTypeName_ = other.maybeTypeName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceHandleProto Clone() {
      return new ResourceHandleProto(this);
    }

    /// <summary>Field number for the "device" field.</summary>
    public const int DeviceFieldNumber = 1;
    private string device_ = "";
    /// <summary>
    /// Unique name for the device containing the resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Device {
      get { return device_; }
      set {
        device_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "container" field.</summary>
    public const int ContainerFieldNumber = 2;
    private string container_ = "";
    /// <summary>
    /// Container in which this resource is placed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Container {
      get { return container_; }
      set {
        container_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// Unique name of this resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hash_code" field.</summary>
    public const int HashCodeFieldNumber = 4;
    private ulong hashCode_;
    /// <summary>
    /// Hash code for the type of the resource. Is only valid in the same device
    /// and in the same execution.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong HashCode {
      get { return hashCode_; }
      set {
        hashCode_ = value;
      }
    }

    /// <summary>Field number for the "maybe_type_name" field.</summary>
    public const int MaybeTypeNameFieldNumber = 5;
    private string maybeTypeName_ = "";
    /// <summary>
    /// For debug-only, the name of the type pointed to by this handle, if
    /// available.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MaybeTypeName {
      get { return maybeTypeName_; }
      set {
        maybeTypeName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResourceHandleProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResourceHandleProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Device != other.Device) return false;
      if (Container != other.Container) return false;
      if (Name != other.Name) return false;
      if (HashCode != other.HashCode) return false;
      if (MaybeTypeName != other.MaybeTypeName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Device.Length != 0) hash ^= Device.GetHashCode();
      if (Container.Length != 0) hash ^= Container.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (HashCode != 0UL) hash ^= HashCode.GetHashCode();
      if (MaybeTypeName.Length != 0) hash ^= MaybeTypeName.GetHashCode();
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
      if (Device.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Device);
      }
      if (Container.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Container);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (HashCode != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(HashCode);
      }
      if (MaybeTypeName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(MaybeTypeName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Device.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Device);
      }
      if (Container.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Container);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (HashCode != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(HashCode);
      }
      if (MaybeTypeName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MaybeTypeName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResourceHandleProto other) {
      if (other == null) {
        return;
      }
      if (other.Device.Length != 0) {
        Device = other.Device;
      }
      if (other.Container.Length != 0) {
        Container = other.Container;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.HashCode != 0UL) {
        HashCode = other.HashCode;
      }
      if (other.MaybeTypeName.Length != 0) {
        MaybeTypeName = other.MaybeTypeName;
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
            Device = input.ReadString();
            break;
          }
          case 18: {
            Container = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 32: {
            HashCode = input.ReadUInt64();
            break;
          }
          case 42: {
            MaybeTypeName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
