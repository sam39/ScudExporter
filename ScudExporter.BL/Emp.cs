//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScudExporter.BL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public int Status { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public byte[] Picture { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Address { get; set; }
        public Nullable<int> Company { get; set; }
        public Nullable<int> Section { get; set; }
        public Nullable<int> Post { get; set; }
        public Nullable<int> Schedule { get; set; }
        public string Avto { get; set; }
        public Nullable<int> Spack { get; set; }
        public Nullable<int> Config { get; set; }
        public string TabNumber { get; set; }
        public Nullable<int> GrStatus { get; set; }
        public Nullable<System.DateTime> ChangeTime { get; set; }
        public Nullable<int> IndexForContactId { get; set; }
        public Nullable<int> StatusRecord { get; set; }
        public Nullable<int> Patterns_ID { get; set; }
        public string ID_Number_List { get; set; }
        public Nullable<int> weight { get; set; }
        public Nullable<int> delta_weight { get; set; }
        public Nullable<int> AutoID { get; set; }
        public string GUID_1C { get; set; }
    
        public virtual Division Division { get; set; }
    }
}
