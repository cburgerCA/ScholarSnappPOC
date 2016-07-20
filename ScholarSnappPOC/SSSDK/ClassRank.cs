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
public partial class ClassRank
{
    
    private string _schoolName;
    
    private SchoolTypesList _schoolType;
    
    private string _otherSchoolDesc;
    
    private bool _schoolRanksStudents;
    
    private RankSystemsList _system;
    
    private string _systemOtherDesc;
    
    private int _classRank1;
    
    private int _classSize;
    
    private decimal _classRankPercentile;
    
    private decimal _classRankPercentileBest;
    
    private string _otherRank;
    
    private string _otherRankDesc;
    
    private RankMethodsList _rankMethod;
    
    public string SchoolName
    {
        get
        {
            return _schoolName;
        }
        set
        {
            _schoolName = value;
        }
    }
    
    public SchoolTypesList SchoolType
    {
        get
        {
            return _schoolType;
        }
        set
        {
            _schoolType = value;
        }
    }
    
    public string OtherSchoolDesc
    {
        get
        {
            return _otherSchoolDesc;
        }
        set
        {
            _otherSchoolDesc = value;
        }
    }
    
    public bool SchoolRanksStudents
    {
        get
        {
            return _schoolRanksStudents;
        }
        set
        {
            _schoolRanksStudents = value;
        }
    }
    
    public RankSystemsList System
    {
        get
        {
            return _system;
        }
        set
        {
            _system = value;
        }
    }
    
    public string SystemOtherDesc
    {
        get
        {
            return _systemOtherDesc;
        }
        set
        {
            _systemOtherDesc = value;
        }
    }
    
    [XmlElementAttribute("ClassRank")]
    public int ClassRank1
    {
        get
        {
            return _classRank1;
        }
        set
        {
            _classRank1 = value;
        }
    }
    
    public int ClassSize
    {
        get
        {
            return _classSize;
        }
        set
        {
            _classSize = value;
        }
    }
    
    public decimal ClassRankPercentile
    {
        get
        {
            return _classRankPercentile;
        }
        set
        {
            _classRankPercentile = value;
        }
    }
    
    public decimal ClassRankPercentileBest
    {
        get
        {
            return _classRankPercentileBest;
        }
        set
        {
            _classRankPercentileBest = value;
        }
    }
    
    public string OtherRank
    {
        get
        {
            return _otherRank;
        }
        set
        {
            _otherRank = value;
        }
    }
    
    public string OtherRankDesc
    {
        get
        {
            return _otherRankDesc;
        }
        set
        {
            _otherRankDesc = value;
        }
    }
    
    public RankMethodsList RankMethod
    {
        get
        {
            return _rankMethod;
        }
        set
        {
            _rankMethod = value;
        }
    }
}
}
#pragma warning restore
