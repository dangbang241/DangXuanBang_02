using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DangXuanBang_02.Models
{
    public class NhaCungCap
    {
        [Key]
        [DisplayName("Mã Nhà Cung Cấp")]
        public int MaNhaCungCap { get; set; }
        [MaxLength(50)]
        [DisplayName("Tên Nhà Cung Cấp")]
        public string TenNhaCungCap { get; set; }
    }
}