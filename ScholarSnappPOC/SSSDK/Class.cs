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
public partial class Class
{
    
    private ClassList _className;
    
    private string _classNameOtherDesc;
    
    private SchoolYearsList _year;
    
    private string _yearOtherDesc;
    
    private ClassStatusList _status;
    
    private string _grade;
    
    private GradingScaleList _scale;
    
    private List<ClassTypeList> _type;
    
    private string _typeOtherDesc;
    
    private string _schoolName;
    
    public Class()
    {
        _type = new List<ClassTypeList>();
    }
    
    public ClassList ClassName
    {
        get
        {
            return _className;
        }
        set
        {
            _className = value;
        }
    }
    
    public string ClassNameOtherDesc
    {
        get
        {
            return _classNameOtherDesc;
        }
        set
        {
            _classNameOtherDesc = value;
        }
    }
    
    public SchoolYearsList Year
    {
        get
        {
            return _year;
        }
        set
        {
            _year = value;
        }
    }
    
    public string YearOtherDesc
    {
        get
        {
            return _yearOtherDesc;
        }
        set
        {
            _yearOtherDesc = value;
        }
    }
    
    public ClassStatusList Status
    {
        get
        {
            return _status;
        }
        set
        {
            _status = value;
        }
    }
    
    public string Grade
    {
        get
        {
            return _grade;
        }
        set
        {
            _grade = value;
        }
    }
    
    public GradingScaleList Scale
    {
        get
        {
            return _scale;
        }
        set
        {
            _scale = value;
        }
    }
    
    [XmlElementAttribute("Type")]
    public List<ClassTypeList> Type
    {
        get
        {
            return _type;
        }
        set
        {
            _type = value;
        }
    }
    
    public string TypeOtherDesc
    {
        get
        {
            return _typeOtherDesc;
        }
        set
        {
            _typeOtherDesc = value;
        }
    }
    
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
}
}
#pragma warning restore
