// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Grpc/Proto/hesap.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RecycleCoin.Grpc {

  /// <summary>Holder for reflection information generated from Grpc/Proto/hesap.proto</summary>
  public static partial class HesapReflection {

    #region Descriptor
    /// <summary>File descriptor for Grpc/Proto/hesap.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HesapReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZHcnBjL1Byb3RvL2hlc2FwLnByb3RvGhtnb29nbGUvcHJvdG9idWYvZW1w",
            "dHkucHJvdG8iVwoKSGVzYXBJc3RlaxIVCg1nZW5lbF9hbmFodGFyGAEgASgJ",
            "Eg0KBWFkcmVzGAIgASgJEhUKBWhlc2FwGAMgASgLMgYuSGVzYXASDAoEYWRl",
            "dBgEIAEoBSJbCgpIZXNhcER1cnVtEg0KBWR1cnVtGAEgASgIEg0KBW1lc2Fq",
            "GAIgASgJEhUKBWhlc2FwGAMgASgLMgYuSGVzYXASGAoIaGVzYXBsYXIYBCAD",
            "KAsyBi5IZXNhcCKGAQoFSGVzYXASCgoCSWQYASABKAMSDQoFYWRyZXMYAiAB",
            "KAkSFQoNZ2VuZWxfYW5haHRhchgDIAEoCRIOCgZiYWtpeWUYBCABKAESEwoL",
            "aXNsZW1fYWRlZGkYBSABKAMSEQoJeWFyYXRpbGRpGAYgASgDEhMKC2d1bmNl",
            "bGxlbmRpGAcgASgDMpwCCgtIZXNhcFNlcnZpcxIgCgRFa2xlEgsuSGVzYXBJ",
            "c3RlaxoLLkhlc2FwRHVydW0SJAoIR3VuY2VsbGUSCy5IZXNhcElzdGVrGgsu",
            "SGVzYXBEdXJ1bRIwChRHZW5lbEFuYWh0YXJJbGVHZXRpchILLkhlc2FwSXN0",
            "ZWsaCy5IZXNhcER1cnVtEikKDUFkcmVzSWxlR2V0aXISCy5IZXNhcElzdGVr",
            "GgsuSGVzYXBEdXJ1bRIzCgxIZXBzaW5pR2V0aXISFi5nb29nbGUucHJvdG9i",
            "dWYuRW1wdHkaCy5IZXNhcER1cnVtEjMKF0VuWmVuZ2luTmFkZXRIZXNhcEdl",
            "dGlyEgsuSGVzYXBJc3RlaxoLLkhlc2FwRHVydW1CE6oCEFJlY3ljbGVDb2lu",
            "LkdycGNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RecycleCoin.Grpc.HesapIstek), global::RecycleCoin.Grpc.HesapIstek.Parser, new[]{ "GenelAnahtar", "Adres", "Hesap", "Adet" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::RecycleCoin.Grpc.HesapDurum), global::RecycleCoin.Grpc.HesapDurum.Parser, new[]{ "Durum", "Mesaj", "Hesap", "Hesaplar" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::RecycleCoin.Grpc.Hesap), global::RecycleCoin.Grpc.Hesap.Parser, new[]{ "Id", "Adres", "GenelAnahtar", "Bakiye", "IslemAdedi", "Yaratildi", "Guncellendi" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HesapIstek : pb::IMessage<HesapIstek>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HesapIstek> _parser = new pb::MessageParser<HesapIstek>(() => new HesapIstek());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HesapIstek> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RecycleCoin.Grpc.HesapReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HesapIstek() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HesapIstek(HesapIstek other) : this() {
      genelAnahtar_ = other.genelAnahtar_;
      adres_ = other.adres_;
      hesap_ = other.hesap_ != null ? other.hesap_.Clone() : null;
      adet_ = other.adet_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HesapIstek Clone() {
      return new HesapIstek(this);
    }

    /// <summary>Field number for the "genel_anahtar" field.</summary>
    public const int GenelAnahtarFieldNumber = 1;
    private string genelAnahtar_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GenelAnahtar {
      get { return genelAnahtar_; }
      set {
        genelAnahtar_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "adres" field.</summary>
    public const int AdresFieldNumber = 2;
    private string adres_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Adres {
      get { return adres_; }
      set {
        adres_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hesap" field.</summary>
    public const int HesapFieldNumber = 3;
    private global::RecycleCoin.Grpc.Hesap hesap_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::RecycleCoin.Grpc.Hesap Hesap {
      get { return hesap_; }
      set {
        hesap_ = value;
      }
    }

    /// <summary>Field number for the "adet" field.</summary>
    public const int AdetFieldNumber = 4;
    private int adet_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Adet {
      get { return adet_; }
      set {
        adet_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HesapIstek);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HesapIstek other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GenelAnahtar != other.GenelAnahtar) return false;
      if (Adres != other.Adres) return false;
      if (!object.Equals(Hesap, other.Hesap)) return false;
      if (Adet != other.Adet) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GenelAnahtar.Length != 0) hash ^= GenelAnahtar.GetHashCode();
      if (Adres.Length != 0) hash ^= Adres.GetHashCode();
      if (hesap_ != null) hash ^= Hesap.GetHashCode();
      if (Adet != 0) hash ^= Adet.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (GenelAnahtar.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GenelAnahtar);
      }
      if (Adres.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Adres);
      }
      if (hesap_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Hesap);
      }
      if (Adet != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Adet);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GenelAnahtar.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GenelAnahtar);
      }
      if (Adres.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Adres);
      }
      if (hesap_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Hesap);
      }
      if (Adet != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Adet);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GenelAnahtar.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GenelAnahtar);
      }
      if (Adres.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Adres);
      }
      if (hesap_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Hesap);
      }
      if (Adet != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Adet);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HesapIstek other) {
      if (other == null) {
        return;
      }
      if (other.GenelAnahtar.Length != 0) {
        GenelAnahtar = other.GenelAnahtar;
      }
      if (other.Adres.Length != 0) {
        Adres = other.Adres;
      }
      if (other.hesap_ != null) {
        if (hesap_ == null) {
          Hesap = new global::RecycleCoin.Grpc.Hesap();
        }
        Hesap.MergeFrom(other.Hesap);
      }
      if (other.Adet != 0) {
        Adet = other.Adet;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            GenelAnahtar = input.ReadString();
            break;
          }
          case 18: {
            Adres = input.ReadString();
            break;
          }
          case 26: {
            if (hesap_ == null) {
              Hesap = new global::RecycleCoin.Grpc.Hesap();
            }
            input.ReadMessage(Hesap);
            break;
          }
          case 32: {
            Adet = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            GenelAnahtar = input.ReadString();
            break;
          }
          case 18: {
            Adres = input.ReadString();
            break;
          }
          case 26: {
            if (hesap_ == null) {
              Hesap = new global::RecycleCoin.Grpc.Hesap();
            }
            input.ReadMessage(Hesap);
            break;
          }
          case 32: {
            Adet = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class HesapDurum : pb::IMessage<HesapDurum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HesapDurum> _parser = new pb::MessageParser<HesapDurum>(() => new HesapDurum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HesapDurum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RecycleCoin.Grpc.HesapReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HesapDurum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HesapDurum(HesapDurum other) : this() {
      durum_ = other.durum_;
      mesaj_ = other.mesaj_;
      hesap_ = other.hesap_ != null ? other.hesap_.Clone() : null;
      hesaplar_ = other.hesaplar_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HesapDurum Clone() {
      return new HesapDurum(this);
    }

    /// <summary>Field number for the "durum" field.</summary>
    public const int DurumFieldNumber = 1;
    private bool durum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Durum {
      get { return durum_; }
      set {
        durum_ = value;
      }
    }

    /// <summary>Field number for the "mesaj" field.</summary>
    public const int MesajFieldNumber = 2;
    private string mesaj_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Mesaj {
      get { return mesaj_; }
      set {
        mesaj_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hesap" field.</summary>
    public const int HesapFieldNumber = 3;
    private global::RecycleCoin.Grpc.Hesap hesap_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::RecycleCoin.Grpc.Hesap Hesap {
      get { return hesap_; }
      set {
        hesap_ = value;
      }
    }

    /// <summary>Field number for the "hesaplar" field.</summary>
    public const int HesaplarFieldNumber = 4;
    private static readonly pb::FieldCodec<global::RecycleCoin.Grpc.Hesap> _repeated_hesaplar_codec
        = pb::FieldCodec.ForMessage(34, global::RecycleCoin.Grpc.Hesap.Parser);
    private readonly pbc::RepeatedField<global::RecycleCoin.Grpc.Hesap> hesaplar_ = new pbc::RepeatedField<global::RecycleCoin.Grpc.Hesap>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::RecycleCoin.Grpc.Hesap> Hesaplar {
      get { return hesaplar_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HesapDurum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HesapDurum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Durum != other.Durum) return false;
      if (Mesaj != other.Mesaj) return false;
      if (!object.Equals(Hesap, other.Hesap)) return false;
      if(!hesaplar_.Equals(other.hesaplar_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Durum != false) hash ^= Durum.GetHashCode();
      if (Mesaj.Length != 0) hash ^= Mesaj.GetHashCode();
      if (hesap_ != null) hash ^= Hesap.GetHashCode();
      hash ^= hesaplar_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Durum != false) {
        output.WriteRawTag(8);
        output.WriteBool(Durum);
      }
      if (Mesaj.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Mesaj);
      }
      if (hesap_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Hesap);
      }
      hesaplar_.WriteTo(output, _repeated_hesaplar_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Durum != false) {
        output.WriteRawTag(8);
        output.WriteBool(Durum);
      }
      if (Mesaj.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Mesaj);
      }
      if (hesap_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Hesap);
      }
      hesaplar_.WriteTo(ref output, _repeated_hesaplar_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Durum != false) {
        size += 1 + 1;
      }
      if (Mesaj.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Mesaj);
      }
      if (hesap_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Hesap);
      }
      size += hesaplar_.CalculateSize(_repeated_hesaplar_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HesapDurum other) {
      if (other == null) {
        return;
      }
      if (other.Durum != false) {
        Durum = other.Durum;
      }
      if (other.Mesaj.Length != 0) {
        Mesaj = other.Mesaj;
      }
      if (other.hesap_ != null) {
        if (hesap_ == null) {
          Hesap = new global::RecycleCoin.Grpc.Hesap();
        }
        Hesap.MergeFrom(other.Hesap);
      }
      hesaplar_.Add(other.hesaplar_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            Durum = input.ReadBool();
            break;
          }
          case 18: {
            Mesaj = input.ReadString();
            break;
          }
          case 26: {
            if (hesap_ == null) {
              Hesap = new global::RecycleCoin.Grpc.Hesap();
            }
            input.ReadMessage(Hesap);
            break;
          }
          case 34: {
            hesaplar_.AddEntriesFrom(input, _repeated_hesaplar_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Durum = input.ReadBool();
            break;
          }
          case 18: {
            Mesaj = input.ReadString();
            break;
          }
          case 26: {
            if (hesap_ == null) {
              Hesap = new global::RecycleCoin.Grpc.Hesap();
            }
            input.ReadMessage(Hesap);
            break;
          }
          case 34: {
            hesaplar_.AddEntriesFrom(ref input, _repeated_hesaplar_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Hesap : pb::IMessage<Hesap>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Hesap> _parser = new pb::MessageParser<Hesap>(() => new Hesap());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Hesap> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RecycleCoin.Grpc.HesapReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Hesap() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Hesap(Hesap other) : this() {
      id_ = other.id_;
      adres_ = other.adres_;
      genelAnahtar_ = other.genelAnahtar_;
      bakiye_ = other.bakiye_;
      islemAdedi_ = other.islemAdedi_;
      yaratildi_ = other.yaratildi_;
      guncellendi_ = other.guncellendi_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Hesap Clone() {
      return new Hesap(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private long id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "adres" field.</summary>
    public const int AdresFieldNumber = 2;
    private string adres_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Adres {
      get { return adres_; }
      set {
        adres_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "genel_anahtar" field.</summary>
    public const int GenelAnahtarFieldNumber = 3;
    private string genelAnahtar_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GenelAnahtar {
      get { return genelAnahtar_; }
      set {
        genelAnahtar_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "bakiye" field.</summary>
    public const int BakiyeFieldNumber = 4;
    private double bakiye_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Bakiye {
      get { return bakiye_; }
      set {
        bakiye_ = value;
      }
    }

    /// <summary>Field number for the "islem_adedi" field.</summary>
    public const int IslemAdediFieldNumber = 5;
    private long islemAdedi_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long IslemAdedi {
      get { return islemAdedi_; }
      set {
        islemAdedi_ = value;
      }
    }

    /// <summary>Field number for the "yaratildi" field.</summary>
    public const int YaratildiFieldNumber = 6;
    private long yaratildi_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Yaratildi {
      get { return yaratildi_; }
      set {
        yaratildi_ = value;
      }
    }

    /// <summary>Field number for the "guncellendi" field.</summary>
    public const int GuncellendiFieldNumber = 7;
    private long guncellendi_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Guncellendi {
      get { return guncellendi_; }
      set {
        guncellendi_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Hesap);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Hesap other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Adres != other.Adres) return false;
      if (GenelAnahtar != other.GenelAnahtar) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Bakiye, other.Bakiye)) return false;
      if (IslemAdedi != other.IslemAdedi) return false;
      if (Yaratildi != other.Yaratildi) return false;
      if (Guncellendi != other.Guncellendi) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Adres.Length != 0) hash ^= Adres.GetHashCode();
      if (GenelAnahtar.Length != 0) hash ^= GenelAnahtar.GetHashCode();
      if (Bakiye != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Bakiye);
      if (IslemAdedi != 0L) hash ^= IslemAdedi.GetHashCode();
      if (Yaratildi != 0L) hash ^= Yaratildi.GetHashCode();
      if (Guncellendi != 0L) hash ^= Guncellendi.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (Adres.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Adres);
      }
      if (GenelAnahtar.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(GenelAnahtar);
      }
      if (Bakiye != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Bakiye);
      }
      if (IslemAdedi != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(IslemAdedi);
      }
      if (Yaratildi != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Yaratildi);
      }
      if (Guncellendi != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(Guncellendi);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (Adres.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Adres);
      }
      if (GenelAnahtar.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(GenelAnahtar);
      }
      if (Bakiye != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Bakiye);
      }
      if (IslemAdedi != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(IslemAdedi);
      }
      if (Yaratildi != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Yaratildi);
      }
      if (Guncellendi != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(Guncellendi);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Adres.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Adres);
      }
      if (GenelAnahtar.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GenelAnahtar);
      }
      if (Bakiye != 0D) {
        size += 1 + 8;
      }
      if (IslemAdedi != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IslemAdedi);
      }
      if (Yaratildi != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Yaratildi);
      }
      if (Guncellendi != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Guncellendi);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Hesap other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Adres.Length != 0) {
        Adres = other.Adres;
      }
      if (other.GenelAnahtar.Length != 0) {
        GenelAnahtar = other.GenelAnahtar;
      }
      if (other.Bakiye != 0D) {
        Bakiye = other.Bakiye;
      }
      if (other.IslemAdedi != 0L) {
        IslemAdedi = other.IslemAdedi;
      }
      if (other.Yaratildi != 0L) {
        Yaratildi = other.Yaratildi;
      }
      if (other.Guncellendi != 0L) {
        Guncellendi = other.Guncellendi;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            Id = input.ReadInt64();
            break;
          }
          case 18: {
            Adres = input.ReadString();
            break;
          }
          case 26: {
            GenelAnahtar = input.ReadString();
            break;
          }
          case 33: {
            Bakiye = input.ReadDouble();
            break;
          }
          case 40: {
            IslemAdedi = input.ReadInt64();
            break;
          }
          case 48: {
            Yaratildi = input.ReadInt64();
            break;
          }
          case 56: {
            Guncellendi = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Id = input.ReadInt64();
            break;
          }
          case 18: {
            Adres = input.ReadString();
            break;
          }
          case 26: {
            GenelAnahtar = input.ReadString();
            break;
          }
          case 33: {
            Bakiye = input.ReadDouble();
            break;
          }
          case 40: {
            IslemAdedi = input.ReadInt64();
            break;
          }
          case 48: {
            Yaratildi = input.ReadInt64();
            break;
          }
          case 56: {
            Guncellendi = input.ReadInt64();
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
