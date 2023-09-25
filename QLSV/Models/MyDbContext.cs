using System;
using Microsoft.EntityFrameworkCore;
namespace QLSV.Models
{
	public class MyDbContext: DbContext
	{
        public MyDbContext(DbContextOptions<MyDbContext> options)
                : base(options)
        { }
        public DbSet<Khachhang> _khang { get; set; } //_khang này phải trùng với tên bảng trên sql

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khachhang>()
                .HasKey(kh => kh.ma_kh);
        }

    }
}

