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
public partial class Citizenship
{
    
    private CitizenshipStatusList _citizenshipStatus;
    
    private string _citizenshipStatusOtherDesc;
    
    private System.DateTime _citizenshipDate;
    
    private string _citizenshipCountry;
    
    public CitizenshipStatusList CitizenshipStatus
    {
        get
        {
            return _citizenshipStatus;
        }
        set
        {
            _citizenshipStatus = value;
        }
    }
    
    public string CitizenshipStatusOtherDesc
    {
        get
        {
            return _citizenshipStatusOtherDesc;
        }
        set
        {
            _citizenshipStatusOtherDesc = value;
        }
    }
    
    [XmlElementAttribute(DataType="date")]
    public System.DateTime CitizenshipDate
    {
        get
        {
            return _citizenshipDate;
        }
        set
        {
            _citizenshipDate = value;
        }
    }
    
    public string CitizenshipCountry
    {
        get
        {
            return _citizenshipCountry;
        }
        set
        {
            _citizenshipCountry = value;
        }
    }
}
}
#pragma warning restore
