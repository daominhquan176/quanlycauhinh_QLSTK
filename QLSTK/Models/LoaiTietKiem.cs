//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLSTK.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiTietKiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiTietKiem()
        {
            this.AspNetUsers = new HashSet<AspNetUser>();
        }
    
        public int MaLoaiTK { get; set; }
        public string TenLoai { get; set; }
        public double LaiSuat { get; set; }
        public int SoThang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
