// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=8fd7408b07f8d2cd.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bnet.protocol.game_master {
  
  public static partial class GameFactory {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_game_master_GameProperties__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.game_master.GameProperties, global::bnet.protocol.game_master.GameProperties.Builder> internal__static_bnet_protocol_game_master_GameProperties__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static GameFactory() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "CiZzZXJ2aWNlL2dhbWVfbWFzdGVyL2dhbWVfZmFjdG9yeS5wcm90bxIZYm5l" + 
          "dC5wcm90b2NvbC5nYW1lX21hc3RlchocbGliL3Byb3RvY29sL2F0dHJpYnV0" + 
          "ZS5wcm90bxoZbGliL3Byb3RvY29sL2VudGl0eS5wcm90byKJAQoOR2FtZVBy" + 
          "b3BlcnRpZXMSOAoGZmlsdGVyGAEgASgLMiguYm5ldC5wcm90b2NvbC5hdHRy" + 
          "aWJ1dGUuQXR0cmlidXRlRmlsdGVyEhUKBmNyZWF0ZRgCIAEoCDoFZmFsc2US" + 
          "EgoEb3BlbhgDIAEoCDoEdHJ1ZRISCgpwcm9ncmFtX2lkGAQgASgH");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_bnet_protocol_game_master_GameProperties__Descriptor = Descriptor.MessageTypes[0];
        internal__static_bnet_protocol_game_master_GameProperties__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.game_master.GameProperties, global::bnet.protocol.game_master.GameProperties.Builder>(internal__static_bnet_protocol_game_master_GameProperties__Descriptor,
                new string[] { "Filter", "Create", "Open", "ProgramId", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::bnet.protocol.attribute.Proto.Attribute.Descriptor, 
          global::bnet.protocol.Entity.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  public sealed partial class GameProperties : pb::GeneratedMessage<GameProperties, GameProperties.Builder> {
    private static readonly GameProperties defaultInstance = new Builder().BuildPartial();
    public static GameProperties DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override GameProperties DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override GameProperties ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.game_master.GameFactory.internal__static_bnet_protocol_game_master_GameProperties__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<GameProperties, GameProperties.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.game_master.GameFactory.internal__static_bnet_protocol_game_master_GameProperties__FieldAccessorTable; }
    }
    
    public const int FilterFieldNumber = 1;
    private bool hasFilter;
    private global::bnet.protocol.attribute.AttributeFilter filter_ = global::bnet.protocol.attribute.AttributeFilter.DefaultInstance;
    public bool HasFilter {
      get { return hasFilter; }
    }
    public global::bnet.protocol.attribute.AttributeFilter Filter {
      get { return filter_; }
    }
    
    public const int CreateFieldNumber = 2;
    private bool hasCreate;
    private bool create_ = false;
    public bool HasCreate {
      get { return hasCreate; }
    }
    public bool Create {
      get { return create_; }
    }
    
    public const int OpenFieldNumber = 3;
    private bool hasOpen;
    private bool open_ = true;
    public bool HasOpen {
      get { return hasOpen; }
    }
    public bool Open {
      get { return open_; }
    }
    
    public const int ProgramIdFieldNumber = 4;
    private bool hasProgramId;
    private uint programId_ = 0;
    public bool HasProgramId {
      get { return hasProgramId; }
    }
    public uint ProgramId {
      get { return programId_; }
    }
    
    public override bool IsInitialized {
      get {
        if (HasFilter) {
          if (!Filter.IsInitialized) return false;
        }
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasFilter) {
        output.WriteMessage(1, Filter);
      }
      if (HasCreate) {
        output.WriteBool(2, Create);
      }
      if (HasOpen) {
        output.WriteBool(3, Open);
      }
      if (HasProgramId) {
        output.WriteFixed32(4, ProgramId);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasFilter) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Filter);
        }
        if (HasCreate) {
          size += pb::CodedOutputStream.ComputeBoolSize(2, Create);
        }
        if (HasOpen) {
          size += pb::CodedOutputStream.ComputeBoolSize(3, Open);
        }
        if (HasProgramId) {
          size += pb::CodedOutputStream.ComputeFixed32Size(4, ProgramId);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static GameProperties ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static GameProperties ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static GameProperties ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static GameProperties ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static GameProperties ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static GameProperties ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static GameProperties ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static GameProperties ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static GameProperties ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static GameProperties ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(GameProperties prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<GameProperties, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      GameProperties result = new GameProperties();
      
      protected override GameProperties MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new GameProperties();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bnet.protocol.game_master.GameProperties.Descriptor; }
      }
      
      public override GameProperties DefaultInstanceForType {
        get { return global::bnet.protocol.game_master.GameProperties.DefaultInstance; }
      }
      
      public override GameProperties BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        GameProperties returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is GameProperties) {
          return MergeFrom((GameProperties) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(GameProperties other) {
        if (other == global::bnet.protocol.game_master.GameProperties.DefaultInstance) return this;
        if (other.HasFilter) {
          MergeFilter(other.Filter);
        }
        if (other.HasCreate) {
          Create = other.Create;
        }
        if (other.HasOpen) {
          Open = other.Open;
        }
        if (other.HasProgramId) {
          ProgramId = other.ProgramId;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag);
              break;
            }
            case 10: {
              global::bnet.protocol.attribute.AttributeFilter.Builder subBuilder = global::bnet.protocol.attribute.AttributeFilter.CreateBuilder();
              if (HasFilter) {
                subBuilder.MergeFrom(Filter);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Filter = subBuilder.BuildPartial();
              break;
            }
            case 16: {
              Create = input.ReadBool();
              break;
            }
            case 24: {
              Open = input.ReadBool();
              break;
            }
            case 37: {
              ProgramId = input.ReadFixed32();
              break;
            }
          }
        }
      }
      
      
      public bool HasFilter {
       get { return result.HasFilter; }
      }
      public global::bnet.protocol.attribute.AttributeFilter Filter {
        get { return result.Filter; }
        set { SetFilter(value); }
      }
      public Builder SetFilter(global::bnet.protocol.attribute.AttributeFilter value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasFilter = true;
        result.filter_ = value;
        return this;
      }
      public Builder SetFilter(global::bnet.protocol.attribute.AttributeFilter.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.hasFilter = true;
        result.filter_ = builderForValue.Build();
        return this;
      }
      public Builder MergeFilter(global::bnet.protocol.attribute.AttributeFilter value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        if (result.HasFilter &&
            result.filter_ != global::bnet.protocol.attribute.AttributeFilter.DefaultInstance) {
            result.filter_ = global::bnet.protocol.attribute.AttributeFilter.CreateBuilder(result.filter_).MergeFrom(value).BuildPartial();
        } else {
          result.filter_ = value;
        }
        result.hasFilter = true;
        return this;
      }
      public Builder ClearFilter() {
        result.hasFilter = false;
        result.filter_ = global::bnet.protocol.attribute.AttributeFilter.DefaultInstance;
        return this;
      }
      
      public bool HasCreate {
        get { return result.HasCreate; }
      }
      public bool Create {
        get { return result.Create; }
        set { SetCreate(value); }
      }
      public Builder SetCreate(bool value) {
        result.hasCreate = true;
        result.create_ = value;
        return this;
      }
      public Builder ClearCreate() {
        result.hasCreate = false;
        result.create_ = false;
        return this;
      }
      
      public bool HasOpen {
        get { return result.HasOpen; }
      }
      public bool Open {
        get { return result.Open; }
        set { SetOpen(value); }
      }
      public Builder SetOpen(bool value) {
        result.hasOpen = true;
        result.open_ = value;
        return this;
      }
      public Builder ClearOpen() {
        result.hasOpen = false;
        result.open_ = true;
        return this;
      }
      
      public bool HasProgramId {
        get { return result.HasProgramId; }
      }
      public uint ProgramId {
        get { return result.ProgramId; }
        set { SetProgramId(value); }
      }
      public Builder SetProgramId(uint value) {
        result.hasProgramId = true;
        result.programId_ = value;
        return this;
      }
      public Builder ClearProgramId() {
        result.hasProgramId = false;
        result.programId_ = 0;
        return this;
      }
    }
    static GameProperties() {
      object.ReferenceEquals(global::bnet.protocol.game_master.GameFactory.Descriptor, null);
    }
  }
  
  #endregion
  
}
