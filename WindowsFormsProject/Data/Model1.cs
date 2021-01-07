using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsProject.Data
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ChiTietPhieuMua> ChiTietPhieuMuas { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Kho> Khoes { get; set; }
        public virtual DbSet<MatHang> MatHangs { get; set; }
        public virtual DbSet<NVBanHang> NVBanHangs { get; set; }
        public virtual DbSet<NVKho> NVKhoes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietPhieuMua>()
                .Property(e => e.MaCTPM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuMua>()
                .Property(e => e.NgayMua)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuMua>()
                .Property(e => e.MaMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.ChiTietPhieuMuas)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kho>()
                .Property(e => e.MaKho)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kho>()
                .Property(e => e.MaMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kho>()
                .Property(e => e.SoLuong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kho>()
                .Property(e => e.DiaChi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.TenMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.ChiTietPhieuMuas)
                .WithRequired(e => e.MatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.Khoes)
                .WithRequired(e => e.MatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NVBanHang>()
                .Property(e => e.TenNVBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NVBanHang>()
                .Property(e => e.ChiNhanh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NVBanHang>()
                .HasMany(e => e.ChiTietPhieuMuas)
                .WithRequired(e => e.NVBanHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NVKho>()
                .Property(e => e.TenNVK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NVKho>()
                .HasMany(e => e.Khoes)
                .WithRequired(e => e.NVKho)
                .WillCascadeOnDelete(false);
        }
    }
}
