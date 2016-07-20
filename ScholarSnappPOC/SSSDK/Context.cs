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
public partial class Context
{
    
    private System.DateTime _created;
    
    private string _createdBy;
    
    private System.DateTime _lastUpdated;
    
    private string _lastUpdatedBy;
    
    private CultureCodeList _applicationLanguage;
    
    private System.DateTime _permissionGivenDate;
    
    public System.DateTime Created
    {
        get
        {
            return _created;
        }
        set
        {
            _created = value;
        }
    }
    
    public string CreatedBy
    {
        get
        {
            return _createdBy;
        }
        set
        {
            _createdBy = value;
        }
    }
    
    public System.DateTime LastUpdated
    {
        get
        {
            return _lastUpdated;
        }
        set
        {
            _lastUpdated = value;
        }
    }
    
    public string LastUpdatedBy
    {
        get
        {
            return _lastUpdatedBy;
        }
        set
        {
            _lastUpdatedBy = value;
        }
    }
    
    public CultureCodeList ApplicationLanguage
    {
        get
        {
            return _applicationLanguage;
        }
        set
        {
            _applicationLanguage = value;
        }
    }
    
    public System.DateTime PermissionGivenDate
    {
        get
        {
            return _permissionGivenDate;
        }
        set
        {
            _permissionGivenDate = value;
        }
    }
}
}
#pragma warning restore