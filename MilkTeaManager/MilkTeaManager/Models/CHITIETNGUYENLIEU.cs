//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MilkTeaManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETNGUYENLIEU
    {
        public string MANL { get; set; }
        public string MACTNL { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<int> GIABAN { get; set; }
        public string MADVT { get; set; }
        public string MASP { get; set; }
    
        public virtual NGUYENLIEU NGUYENLIEU { get; set; }
        public virtual DONVITINH DONVITINH { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
