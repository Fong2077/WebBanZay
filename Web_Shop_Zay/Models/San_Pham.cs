//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Shop_Zay.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class San_Pham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public San_Pham()
        {
            this.Chi_Tiet_HD = new HashSet<Chi_Tiet_HD>();
            this.ChiTietSps = new HashSet<ChiTietSp>();
        }
    
        public int MaSP { get; set; }
        public Nullable<int> MaPL { get; set; }
        public string TenSP { get; set; }
        public string MoTa { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> Gia { get; set; }
        public string Hinh { get; set; }
        public string TrangThai { get; set; }
        public string Size { get; set; }
        public string GiamGia { get; set; }
        public Nullable<int> LuotXem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chi_Tiet_HD> Chi_Tiet_HD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
        public virtual Phan_Loai_SP Phan_Loai_SP { get; set; }
    }
}
