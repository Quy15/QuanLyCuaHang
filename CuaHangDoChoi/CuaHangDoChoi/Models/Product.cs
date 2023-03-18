//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuaHangDoChoi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ReceiptDetails = new HashSet<ReceiptDetail>();
        }
    
        public int id { get; set; }
        public string tenSP { get; set; }
        public Nullable<int> giaBan { get; set; }
        public Nullable<int> soLuong { get; set; }
        public string moTa { get; set; }
        public string hinhAnh { get; set; }
        public Nullable<int> id_LoaiSP { get; set; }
        public Nullable<int> id_NCC { get; set; }
        public Nullable<bool> tinhTrang { get; set; }
    
        public virtual Category Category { get; set; }

        public void setTT (string tt)
        {
            if (tt == "C�n h�ng")
            {
                this.tinhTrang = true;
            }
            else
            {
                this.tinhTrang = false;
            }
        }

        public virtual Suplier Suplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; }
    }
}