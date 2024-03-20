//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanDoDienTu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;
    public partial class MatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatHang()
        {
            this.ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
        }
    
        public int IDMH { get; set; }
        [Required]
        public string TenMH { get; set; }
        [Required]
        public Nullable<int> IDLoaiMH { get; set; }
        public string MoTa { get; set; }
        [Range(0,int.MaxValue)]
        public Nullable<int> DonGia { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> NgayNhapHang { get; set; }
        [Range(0,int.MaxValue)]
        public Nullable<int> SoLuong { get; set; }
        public byte[] HinhAnh1 { get; set; }
        public byte[] HinhAnh2 { get; set; }
        public byte[] HinhAnh3 { get; set; }
        public byte[] HinhAnh4 { get; set; }
        public string MoTaChiTiet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
        public virtual LoaiMatHang LoaiMatHang { get; set; }

        [NotMapped]
        public HttpPostedFileBase UploadImage1 { get; set; }

        [NotMapped]
        public HttpPostedFileBase UploadImage2 { get; set; }

        [NotMapped]
        public HttpPostedFileBase UploadImage3 { get; set; }

        [NotMapped]
        public HttpPostedFileBase UploadImage4 { get; set; }
    }
}
