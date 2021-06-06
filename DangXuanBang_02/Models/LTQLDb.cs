using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DangXuanBang_02.Models
{
    public partial class LTQLDb : DbContext
    {
        public LTQLDb()
            : base("name=LTQLDb")
        {
        }

        public DbSet<NhaCungCap> NhaCungCaps { get; set; } 
        public DbSet<SanPham> SanPhams { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
