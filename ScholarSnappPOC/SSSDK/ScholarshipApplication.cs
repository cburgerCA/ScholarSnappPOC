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
[XmlRootAttribute(Namespace="http://scholarshipproviders.org/scholarshipapplication", IsNullable=false)]
public partial class ScholarshipApplication
{
    
    private Context _context;
    
    private List<AttachedFile> _attachedFiles;
    
    private Student _student;
    
    public ScholarshipApplication()
    {
        _student = new Student();
        _attachedFiles = new List<AttachedFile>();
        _context = new Context();
    }
    
    public Context Context
    {
        get
        {
            return _context;
        }
        set
        {
            _context = value;
        }
    }
    
    [XmlElementAttribute("AttachedFiles")]
    public List<AttachedFile> AttachedFiles
    {
        get
        {
            return _attachedFiles;
        }
        set
        {
            _attachedFiles = value;
        }
    }
    
    public Student Student
    {
        get
        {
            return _student;
        }
        set
        {
            _student = value;
        }
    }
}
}
#pragma warning restore
