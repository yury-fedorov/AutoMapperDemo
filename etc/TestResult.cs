// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: test-result.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Demo {

  /// <summary>Holder for reflection information generated from test-result.proto</summary>
  public static partial class TestResultReflection {

    #region Descriptor
    /// <summary>File descriptor for test-result.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TestResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChF0ZXN0LXJlc3VsdC5wcm90bxIEZGVtbyKVAQoKVGVzdFJlc3VsdBIPCgdQ",
            "YWNrYWdlGAEgASgJEg0KBUNsYXNzGAIgASgJEhwKBlN0YXR1cxgDIAEoDjIM",
            "LmRlbW8uU3RhdHVzEg0KBUVycm9yGAQgASgJEhIKClN0YWNrVHJhY2UYBSAB",
            "KAkSEgoKRHVyYXRpb25NcxgGIAEoAxISCgpDaGVja0NvdW50GAcgASgFKjEK",
            "BlN0YXR1cxIMCghzU3VjY2VzcxAAEgsKB3NGYWlsZWQQARIMCghzU2tpcHBl",
            "ZBACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Demo.Status), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Demo.TestResult), global::Demo.TestResult.Parser, new[]{ "Package", "Class", "Status", "Error", "StackTrace", "DurationMs", "CheckCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Status {
    [pbr::OriginalName("sSuccess")] SSuccess = 0,
    [pbr::OriginalName("sFailed")] SFailed = 1,
    [pbr::OriginalName("sSkipped")] SSkipped = 2,
  }

  #endregion

  #region Messages
  public sealed partial class TestResult : pb::IMessage<TestResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TestResult> _parser = new pb::MessageParser<TestResult>(() => new TestResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TestResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Demo.TestResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestResult(TestResult other) : this() {
      package_ = other.package_;
      class_ = other.class_;
      status_ = other.status_;
      error_ = other.error_;
      stackTrace_ = other.stackTrace_;
      durationMs_ = other.durationMs_;
      checkCount_ = other.checkCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestResult Clone() {
      return new TestResult(this);
    }

    /// <summary>Field number for the "Package" field.</summary>
    public const int PackageFieldNumber = 1;
    private string package_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Package {
      get { return package_; }
      set {
        package_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Class" field.</summary>
    public const int ClassFieldNumber = 2;
    private string class_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Class {
      get { return class_; }
      set {
        class_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::Demo.Status status_ = global::Demo.Status.SSuccess;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Demo.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "Error" field.</summary>
    public const int ErrorFieldNumber = 4;
    private string error_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Error {
      get { return error_; }
      set {
        error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "StackTrace" field.</summary>
    public const int StackTraceFieldNumber = 5;
    private string stackTrace_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StackTrace {
      get { return stackTrace_; }
      set {
        stackTrace_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DurationMs" field.</summary>
    public const int DurationMsFieldNumber = 6;
    private long durationMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long DurationMs {
      get { return durationMs_; }
      set {
        durationMs_ = value;
      }
    }

    /// <summary>Field number for the "CheckCount" field.</summary>
    public const int CheckCountFieldNumber = 7;
    private int checkCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CheckCount {
      get { return checkCount_; }
      set {
        checkCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TestResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TestResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Package != other.Package) return false;
      if (Class != other.Class) return false;
      if (Status != other.Status) return false;
      if (Error != other.Error) return false;
      if (StackTrace != other.StackTrace) return false;
      if (DurationMs != other.DurationMs) return false;
      if (CheckCount != other.CheckCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Package.Length != 0) hash ^= Package.GetHashCode();
      if (Class.Length != 0) hash ^= Class.GetHashCode();
      if (Status != global::Demo.Status.SSuccess) hash ^= Status.GetHashCode();
      if (Error.Length != 0) hash ^= Error.GetHashCode();
      if (StackTrace.Length != 0) hash ^= StackTrace.GetHashCode();
      if (DurationMs != 0L) hash ^= DurationMs.GetHashCode();
      if (CheckCount != 0) hash ^= CheckCount.GetHashCode();
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
      if (Package.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Package);
      }
      if (Class.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Class);
      }
      if (Status != global::Demo.Status.SSuccess) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (Error.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Error);
      }
      if (StackTrace.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StackTrace);
      }
      if (DurationMs != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(DurationMs);
      }
      if (CheckCount != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(CheckCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Package.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Package);
      }
      if (Class.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Class);
      }
      if (Status != global::Demo.Status.SSuccess) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Error.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
      }
      if (StackTrace.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StackTrace);
      }
      if (DurationMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DurationMs);
      }
      if (CheckCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CheckCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TestResult other) {
      if (other == null) {
        return;
      }
      if (other.Package.Length != 0) {
        Package = other.Package;
      }
      if (other.Class.Length != 0) {
        Class = other.Class;
      }
      if (other.Status != global::Demo.Status.SSuccess) {
        Status = other.Status;
      }
      if (other.Error.Length != 0) {
        Error = other.Error;
      }
      if (other.StackTrace.Length != 0) {
        StackTrace = other.StackTrace;
      }
      if (other.DurationMs != 0L) {
        DurationMs = other.DurationMs;
      }
      if (other.CheckCount != 0) {
        CheckCount = other.CheckCount;
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
          case 10: {
            Package = input.ReadString();
            break;
          }
          case 18: {
            Class = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::Demo.Status) input.ReadEnum();
            break;
          }
          case 34: {
            Error = input.ReadString();
            break;
          }
          case 42: {
            StackTrace = input.ReadString();
            break;
          }
          case 48: {
            DurationMs = input.ReadInt64();
            break;
          }
          case 56: {
            CheckCount = input.ReadInt32();
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
          case 10: {
            Package = input.ReadString();
            break;
          }
          case 18: {
            Class = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::Demo.Status) input.ReadEnum();
            break;
          }
          case 34: {
            Error = input.ReadString();
            break;
          }
          case 42: {
            StackTrace = input.ReadString();
            break;
          }
          case 48: {
            DurationMs = input.ReadInt64();
            break;
          }
          case 56: {
            CheckCount = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
