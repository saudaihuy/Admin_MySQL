//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admin_MySQL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class danhgia
    {
        public long danhgia_id { get; set; }
        public string noidungdanhgia { get; set; }
        public Nullable<long> rating { get; set; }
        public Nullable<long> sanpham_id { get; set; }
        public Nullable<long> customer_id { get; set; }
        public System.DateTime ngaydanhgia { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual sanpham sanpham { get; set; }
    }
}