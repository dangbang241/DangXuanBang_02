using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DangXuanBang_02.Models
{
    public class SanPham
    {
        [Key]
        [DisplayName("Mã Sản phẩm")]
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int MaNhaCungCap { get; set; }

    }
}