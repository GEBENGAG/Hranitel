//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppConnect.DatabaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class VisitStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VisitStatus()
        {
            this.VisitRequest = new HashSet<VisitRequest>();
        }
    
        public int VisitStatusID { get; set; }
        public string VisitStatusName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitRequest> VisitRequest { get; set; }
    }
}