namespace WindowsFormsProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuMua")]
    public partial class ChiTietPhieuMua
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string MaCTPM { get; set; }

        [StringLength(30)]
        public string NgayMua { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string MaMH { get; set; }

        public int MaKH { get; set; }

        public int MaNVBH { get; set; }

        public virtual NVBanHang NVBanHang { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual MatHang MatHang { get; set; }
    }
}
