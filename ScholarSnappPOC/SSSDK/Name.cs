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
public partial class Name
{
    
    private string _salutation;
    
    private string _firstName;
    
    private string _middleName;
    
    private string _middleName2;
    
    private string _lastName;
    
    private string _suffix;
    
    private string _preferredName;
    
    public string Salutation
    {
        get
        {
            return _salutation;
        }
        set
        {
            _salutation = value;
        }
    }
    
    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            _firstName = value;
        }
    }
    
    public string MiddleName
    {
        get
        {
            return _middleName;
        }
        set
        {
            _middleName = value;
        }
    }
    
    public string MiddleName2
    {
        get
        {
            return _middleName2;
        }
        set
        {
            _middleName2 = value;
        }
    }
    
    public string LastName
    {
        get
        {
            return _lastName;
        }
        set
        {
            _lastName = value;
        }
    }
    
    public string Suffix
    {
        get
        {
            return _suffix;
        }
        set
        {
            _suffix = value;
        }
    }
    
    public string PreferredName
    {
        get
        {
            return _preferredName;
        }
        set
        {
            _preferredName = value;
        }
    }
}
}
#pragma warning restore
