//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBX.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHUYENXE
    {
        public string IDCHUYEN { get; set; }
        public string IDTUYEN { get; set; }
        public string BIENSO { get; set; }
        public Nullable<System.TimeSpan> THOIGIANKHOIHANH { get; set; }
        public Nullable<System.DateTime> THOIGIANDEN { get; set; }
        public Nullable<decimal> GIAVECHUYEN { get; set; }
        public string TAI1 { get; set; }
        public string TAI2 { get; set; }
        public string LO1 { get; set; }
        public string LO2 { get; set; }
    
        public virtual GIOKHOIHANH GIOKHOIHANH { get; set; }
        public virtual TUYENXE TUYENXE { get; set; }
        public virtual XE XE { get; set; }
        public virtual NHANVIENXE NHANVIENXE { get; set; }
        public virtual NHANVIENXE NHANVIENXE1 { get; set; }
        public virtual NHANVIENXE NHANVIENXE2 { get; set; }
        public virtual NHANVIENXE NHANVIENXE3 { get; set; }
    }
}
