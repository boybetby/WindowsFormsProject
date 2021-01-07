namespace WindowsFormsProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NVBanHang")]
    public partial class NVBanHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NVBanHang()
        {
            ChiTietPhieuMuas = new HashSet<ChiTietPhieuMua>();
        }

        [Key]
        public int MaNVBH { get; set; }

        [StringLength(30)]
        public string TenNVBH { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(30)]
        public string ChiNhanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuMua> ChiTietPhieuMuas { get; set; }
    }
}
