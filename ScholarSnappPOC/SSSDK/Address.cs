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
public partial class Address
{
    
    private AddressTypesList _addressType;
    
    private string _addressLine1;
    
    private string _addressLine2;
    
    private string _addressLine3;
    
    private string _addressLine4;
    
    private string _city;
    
    private string _county;
    
    private string _stateOrProvince;
    
    private string _zipOrPostalCode;
    
    private string _country;
    
    public AddressTypesList AddressType
    {
        get
        {
            return _addressType;
        }
        set
        {
            _addressType = value;
        }
    }
    
    public string AddressLine1
    {
        get
        {
            return _addressLine1;
        }
        set
        {
            _addressLine1 = value;
        }
    }
    
    public string AddressLine2
    {
        get
        {
            return _addressLine2;
        }
        set
        {
            _addressLine2 = value;
        }
    }
    
    public string AddressLine3
    {
        get
        {
            return _addressLine3;
        }
        set
        {
            _addressLine3 = value;
        }
    }
    
    public string AddressLine4
    {
        get
        {
            return _addressLine4;
        }
        set
        {
            _addressLine4 = value;
        }
    }
    
    public string City
    {
        get
        {
            return _city;
        }
        set
        {
            _city = value;
        }
    }
    
    public string County
    {
        get
        {
            return _county;
        }
        set
        {
            _county = value;
        }
    }
    
    public string StateOrProvince
    {
        get
        {
            return _stateOrProvince;
        }
        set
        {
            _stateOrProvince = value;
        }
    }
    
    public string ZipOrPostalCode
    {
        get
        {
            return _zipOrPostalCode;
        }
        set
        {
            _zipOrPostalCode = value;
        }
    }
    
    public string Country
    {
        get
        {
            return _country;
        }
        set
        {
            _country = value;
        }
    }
}
}
#pragma warning restore