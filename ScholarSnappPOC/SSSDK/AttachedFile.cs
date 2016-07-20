// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.15
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace SSSDK
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://scholarshipproviders.org/scholarshipapplication")]
public partial class AttachedFile
{
    
    private string _fileName;
    
    private string _fileNameExtension;
    
    private AttachedFileTypeList _fileDescription;
    
    private string _fileOtherDesc;
    
    private System.DateTime _dateAttached;
    
    private byte[] _file;
    
    public string FileName
    {
        get
        {
            return _fileName;
        }
        set
        {
            _fileName = value;
        }
    }
    
    public string FileNameExtension
    {
        get
        {
            return _fileNameExtension;
        }
        set
        {
            _fileNameExtension = value;
        }
    }
    
    public AttachedFileTypeList FileDescription
    {
        get
        {
            return _fileDescription;
        }
        set
        {
            _fileDescription = value;
        }
    }
    
    public string FileOtherDesc
    {
        get
        {
            return _fileOtherDesc;
        }
        set
        {
            _fileOtherDesc = value;
        }
    }
    
    public System.DateTime DateAttached
    {
        get
        {
            return _dateAttached;
        }
        set
        {
            _dateAttached = value;
        }
    }
    
    [XmlElementAttribute(DataType="base64Binary")]
    public byte[] File
    {
        get
        {
            return _file;
        }
        set
        {
            _file = value;
        }
    }
}
}
#pragma warning restore
