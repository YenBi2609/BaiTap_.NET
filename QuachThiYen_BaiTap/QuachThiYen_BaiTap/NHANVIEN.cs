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
    
    public partial class NHANVIEN
    {
        public string MANV { get; set; }
        public string TENNV { get; set; }
        public Nullable<double> HESO_LUONG { get; set; }
        public string MACV { get; set; }
        public string MAPB { get; set; }
    
        public virtual CHUCVU CHUCVU { get; set; }
        public virtual PHONGBAN PHONGBAN { get; set; }
    }
}