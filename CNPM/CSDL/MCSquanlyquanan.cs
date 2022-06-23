using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CNPM.CSDL
{
    public partial class MCSquanlyquanan : DbContext
    {
        public MCSquanlyquanan()
            : base("name=MCSquanlyquanan")
        {
        }

        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<MonAn> MonAns { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.NgayLHD)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaMA)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DiaChiKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDTKH)
                .IsFixedLength();

            modelBuilder.Entity<MonAn>()
                .Property(e => e.MaMA)
                .IsFixedLength();

            modelBuilder.Entity<MonAn>()
                .Property(e => e.TenMA)
                .IsFixedLength();

            modelBuilder.Entity<MonAn>()
                .Property(e => e.Gia)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.HoTen)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.NgaySinh)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDT)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ChucVu)
                .IsFixedLength();
        }
    }
}
