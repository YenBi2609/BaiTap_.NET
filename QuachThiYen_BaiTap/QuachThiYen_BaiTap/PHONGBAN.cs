//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuachThiYen_BaiTap
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHONGBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONGBAN()
        {
            this.NHANVIENs = new HashSet<NHANVIEN>();
        }
    
        public string MAPB { get; set; }
        public string TENPB { get; set; }
        public string DIACHI { get; set; }
        public string CHUCNANG { get; set; }
        public string SODT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}
