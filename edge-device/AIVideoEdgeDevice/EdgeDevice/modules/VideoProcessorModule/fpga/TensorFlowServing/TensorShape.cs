// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/core/framework/tensor_shape.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/framework/tensor_shape.proto</summary>
  public static partial class TensorShapeReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/framework/tensor_shape.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TensorShapeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cix0ZW5zb3JmbG93L2NvcmUvZnJhbWV3b3JrL3RlbnNvcl9zaGFwZS5wcm90",
            "bxIKdGVuc29yZmxvdyJ6ChBUZW5zb3JTaGFwZVByb3RvEi0KA2RpbRgCIAMo",
            "CzIgLnRlbnNvcmZsb3cuVGVuc29yU2hhcGVQcm90by5EaW0SFAoMdW5rbm93",
            "bl9yYW5rGAMgASgIGiEKA0RpbRIMCgRzaXplGAEgASgDEgwKBG5hbWUYAiAB",
            "KAlCMgoYb3JnLnRlbnNvcmZsb3cuZnJhbWV3b3JrQhFUZW5zb3JTaGFwZVBy",
            "b3Rvc1AB+AEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.TensorShapeProto), global::Tensorflow.TensorShapeProto.Parser, new[]{ "Dim", "UnknownRank" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.TensorShapeProto.Types.Dim), global::Tensorflow.TensorShapeProto.Types.Dim.Parser, new[]{ "Size", "Name" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Dimensions of a tensor.
  /// </summary>
  public sealed partial class TensorShapeProto : pb::IMessage<TensorShapeProto> {
    private static readonly pb::MessageParser<TensorShapeProto> _parser = new pb::MessageParser<TensorShapeProto>(() => new TensorShapeProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TensorShapeProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.TensorShapeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TensorShapeProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TensorShapeProto(TensorShapeProto other) : this() {
      dim_ = other.dim_.Clone();
      unknownRank_ = other.unknownRank_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TensorShapeProto Clone() {
      return new TensorShapeProto(this);
    }

    /// <summary>Field number for the "dim" field.</summary>
    public const int DimFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Tensorflow.TensorShapeProto.Types.Dim> _repeated_dim_codec
        = pb::FieldCodec.ForMessage(18, global::Tensorflow.TensorShapeProto.Types.Dim.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.TensorShapeProto.Types.Dim> dim_ = new pbc::RepeatedField<global::Tensorflow.TensorShapeProto.Types.Dim>();
    /// <summary>
    /// Dimensions of the tensor, such as {"input", 30}, {"output", 40}
    /// for a 30 x 40 2D tensor.  If an entry has size -1, this
    /// corresponds to a dimension of unknown size. The names are
    /// optional.
    ///
    /// The order of entries in "dim" matters: It indicates the layout of the
    /// values in the tensor in-memory representation.
    ///
    /// The first entry in "dim" is the outermost dimension used to layout the
    /// values, the last entry is the innermost dimension.  This matches the
    /// in-memory layout of RowMajor Eigen tensors.
    ///
    /// If "dim.size()" > 0, "unknown_rank" must be false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.TensorShapeProto.Types.Dim> Dim {
      get { return dim_; }
    }

    /// <summary>Field number for the "unknown_rank" field.</summary>
    public const int UnknownRankFieldNumber = 3;
    private bool unknownRank_;
    /// <summary>
    /// If true, the number of dimensions in the shape is unknown.
    ///
    /// If true, "dim.size()" must be 0.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool UnknownRank {
      get { return unknownRank_; }
      set {
        unknownRank_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TensorShapeProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TensorShapeProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!dim_.Equals(other.dim_)) return false;
      if (UnknownRank != other.UnknownRank) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= dim_.GetHashCode();
      if (UnknownRank != false) hash ^= UnknownRank.GetHashCode();
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
      dim_.WriteTo(output, _repeated_dim_codec);
      if (UnknownRank != false) {
        output.WriteRawTag(24);
        output.WriteBool(UnknownRank);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += dim_.CalculateSize(_repeated_dim_codec);
      if (UnknownRank != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TensorShapeProto other) {
      if (other == null) {
        return;
      }
      dim_.Add(other.dim_);
      if (other.UnknownRank != false) {
        UnknownRank = other.UnknownRank;
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
          case 18: {
            dim_.AddEntriesFrom(input, _repeated_dim_codec);
            break;
          }
          case 24: {
            UnknownRank = input.ReadBool();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the TensorShapeProto message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// One dimension of the tensor.
      /// </summary>
      public sealed partial class Dim : pb::IMessage<Dim> {
        private static readonly pb::MessageParser<Dim> _parser = new pb::MessageParser<Dim>(() => new Dim());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Dim> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Tensorflow.TensorShapeProto.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Dim() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Dim(Dim other) : this() {
          size_ = other.size_;
          name_ = other.name_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Dim Clone() {
          return new Dim(this);
        }

        /// <summary>Field number for the "size" field.</summary>
        public const int SizeFieldNumber = 1;
        private long size_;
        /// <summary>
        /// Size of the tensor in that dimension.
        /// This value must be >= -1, but values of -1 are reserved for "unknown"
        /// shapes (values of -1 mean "unknown" dimension).  Certain wrappers
        /// that work with TensorShapeProto may fail at runtime when deserializing
        /// a TensorShapeProto containing a dim value of -1.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long Size {
          get { return size_; }
          set {
            size_ = value;
          }
        }

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 2;
        private string name_ = "";
        /// <summary>
        /// Optional name of the tensor dimension.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Name {
          get { return name_; }
          set {
            name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Dim);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Dim other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Size != other.Size) return false;
          if (Name != other.Name) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Size != 0L) hash ^= Size.GetHashCode();
          if (Name.Length != 0) hash ^= Name.GetHashCode();
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
          if (Size != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(Size);
          }
          if (Name.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Name);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Size != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(Size);
          }
          if (Name.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Dim other) {
          if (other == null) {
            return;
          }
          if (other.Size != 0L) {
            Size = other.Size;
          }
          if (other.Name.Length != 0) {
            Name = other.Name;
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
                Size = input.ReadInt64();
                break;
              }
              case 18: {
                Name = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
