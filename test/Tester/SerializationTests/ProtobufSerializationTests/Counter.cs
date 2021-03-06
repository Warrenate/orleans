// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: counter.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace UnitTests.Serialization {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Counter {

      #region Descriptor
      public static pbr::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbr::FileDescriptor descriptor;

      static Counter() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "Cg1jb3VudGVyLnByb3RvEgh0dXRvcmlhbCIjCgdDb3VudGVyEgwKBG5hbWUY", 
              "ASABKAkSCgoCaWQYAiABKAVCGqoCF1VuaXRUZXN0cy5TZXJpYWxpemF0aW9u", 
              "YgZwcm90bzM="));
        descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbr::FileDescriptor[] { },
            new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
              new pbr::GeneratedCodeInfo(typeof(global::UnitTests.Serialization.Counter), new[]{ "Name", "Id" }, null, null, null)
            }));
      }
      #endregion

    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Counter : pb::IMessage<Counter> {
    private static readonly pb::MessageParser<Counter> _parser = new pb::MessageParser<Counter>(() => new Counter());
    public static pb::MessageParser<Counter> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::UnitTests.Serialization.Proto.Counter.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Counter() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Counter(Counter other) : this() {
      name_ = other.name_;
      id_ = other.id_;
    }

    public Counter Clone() {
      return new Counter(this);
    }

    public const int NameFieldNumber = 1;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int IdFieldNumber = 2;
    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Counter);
    }

    public bool Equals(Counter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Id);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      return size;
    }

    public void MergeFrom(Counter other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
