namespace WindowsFormsProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kho")]
    public partial class Kho
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaKho { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string MaMH { get; set; }

        public int MaNVK { get; set; }

        [StringLength(10)]
        public string SoLuong { get; set; }

        [StringLength(10)]
        public string DiaChi { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual NVKho NVKho { get; set; }
    }
}
