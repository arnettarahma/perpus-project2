//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace perpus_project2.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class sysuserprofile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysuserprofile()
        {
            this.sysusers = new HashSet<sysuser>();
        }
    
        public int sysuserprofileid { get; set; }
        public int sysuserid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public int rowcreatedsysuserid { get; set; }
        public System.DateTime rowcreateddatetime { get; set; }
        public int rowmodifiedsysuserid { get; set; }
        public System.DateTime rowmodifieddatetime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysuser> sysusers { get; set; }
    }
}
