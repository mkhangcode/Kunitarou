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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Database_web_mô_hìnhEntities : DbContext
    {
        public Database_web_mô_hìnhEntities()
            : base("name=Database_web_mô_hìnhEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Table_chủ_đề> Table_chủ_đề { get; set; }
        public virtual DbSet<Table_đơn_đặt_hàng> Table_đơn_đặt_hàng { get; set; }
        public virtual DbSet<Table_khách_hàng> Table_khách_hàng { get; set; }
        public virtual DbSet<Table_mô_hình> Table_mô_hình { get; set; }
        public virtual DbSet<Table_nhà_sản_xuất> Table_nhà_sản_xuất { get; set; }
        public virtual DbSet<Table_kiểm_soát_đặt_hàng> Table_kiểm_soát_đặt_hàng { get; set; }
    }
}
