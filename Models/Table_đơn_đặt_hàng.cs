//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEB_CUOIKI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_đơn_đặt_hàng
    {
        public string Mã_đơn_hàng { get; set; }
        public string Mã_khách_hàng { get; set; }
        public Nullable<System.DateTime> Ngày_đặt_hàng { get; set; }
        public Nullable<int> Trị_giá { get; set; }
        public string Đã_giao { get; set; }
        public Nullable<System.DateTime> Ngày_giao_hàng { get; set; }
        public string Tên_người_nhận { get; set; }
        public string Địa_chỉ_nhận { get; set; }
        public string Sđt_nhận { get; set; }
        public string Hình_thức_thanh_toán { get; set; }
        public string Hình_thức_giao_hàng { get; set; }
    
        public virtual Table_khách_hàng Table_khách_hàng { get; set; }
        public virtual Table_kiểm_soát_đặt_hàng Table_kiểm_soát_đặt_hàng { get; set; }
    }
}
