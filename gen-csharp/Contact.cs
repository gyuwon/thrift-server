/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;


#if !SILVERLIGHT
[Serializable]
#endif
public partial class Contact : TBase
{

  public int Id { get; set; }

  public string FirstName { get; set; }

  public string LastName { get; set; }

  public string Email { get; set; }

  public Contact() {
  }

  public Contact(int id, string firstName, string lastName, string email) : this() {
    this.Id = id;
    this.FirstName = firstName;
    this.LastName = lastName;
    this.Email = email;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_id = false;
    bool isset_firstName = false;
    bool isset_lastName = false;
    bool isset_email = false;
    TField field;
    iprot.ReadStructBegin();
    while (true)
    {
      field = iprot.ReadFieldBegin();
      if (field.Type == TType.Stop) { 
        break;
      }
      switch (field.ID)
      {
        case 1:
          if (field.Type == TType.I32) {
            Id = iprot.ReadI32();
            isset_id = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.String) {
            FirstName = iprot.ReadString();
            isset_firstName = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 3:
          if (field.Type == TType.String) {
            LastName = iprot.ReadString();
            isset_lastName = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 4:
          if (field.Type == TType.String) {
            Email = iprot.ReadString();
            isset_email = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        default: 
          TProtocolUtil.Skip(iprot, field.Type);
          break;
      }
      iprot.ReadFieldEnd();
    }
    iprot.ReadStructEnd();
    if (!isset_id)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_firstName)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_lastName)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_email)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("Contact");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "id";
    field.Type = TType.I32;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    oprot.WriteI32(Id);
    oprot.WriteFieldEnd();
    field.Name = "firstName";
    field.Type = TType.String;
    field.ID = 2;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(FirstName);
    oprot.WriteFieldEnd();
    field.Name = "lastName";
    field.Type = TType.String;
    field.ID = 3;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(LastName);
    oprot.WriteFieldEnd();
    field.Name = "email";
    field.Type = TType.String;
    field.ID = 4;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(Email);
    oprot.WriteFieldEnd();
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder sb = new StringBuilder("Contact(");
    sb.Append("Id: ");
    sb.Append(Id);
    sb.Append(",FirstName: ");
    sb.Append(FirstName);
    sb.Append(",LastName: ");
    sb.Append(LastName);
    sb.Append(",Email: ");
    sb.Append(Email);
    sb.Append(")");
    return sb.ToString();
  }

}

