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
    
    public partial class pelanggan
    {
        public int id_pelanggan { get; set; }
        public int no_id { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string no_tlp1 { get; set; }
        public string no_tlp2 { get; set; }
    
        public virtual laporan laporan { get; set; }
    }
}
