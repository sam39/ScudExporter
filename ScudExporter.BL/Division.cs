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
    
    public partial class Division
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Division()
        {
            this.Emp = new HashSet<Emp>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Shedule { get; set; }
        public Nullable<int> GroupID { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<int> PCompany_ID { get; set; }
        public string ID_Number_Division { get; set; }
        public Nullable<int> ID_Owner_Division { get; set; }
        public Nullable<int> Patterns_ID { get; set; }
        public string GUID_1C { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emp> Emp { get; set; }
    }
}
