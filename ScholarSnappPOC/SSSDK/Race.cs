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
public partial class Race
{
    
    private List<RacesList> _race1;
    
    private string _raceOtherDesc;
    
    public Race()
    {
        _race1 = new List<RacesList>();
    }
    
    [XmlElementAttribute("Race")]
    public List<RacesList> Race1
    {
        get
        {
            return _race1;
        }
        set
        {
            _race1 = value;
        }
    }
    
    public string RaceOtherDesc
    {
        get
        {
            return _raceOtherDesc;
        }
        set
        {
            _raceOtherDesc = value;
        }
    }
}
}
#pragma warning restore
