//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnoServiceGoncharovUP01
{
    using System;
    using System.Collections.Generic;
    
    public partial class Technician
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Technician()
        {
            this.Request = new HashSet<Request>();
            this.Users = new HashSet<Users>();
        }
    
        public int technician_id { get; set; }
        public string technician_surname { get; set; }
        public string technician_name { get; set; }
        public string technician_secondName { get; set; }
        public Nullable<int> position_id { get; set; }
        public string contact_info { get; set; }
    
        public virtual Position Position { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users> Users { get; set; }
    }
}
