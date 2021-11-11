using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages
{
    public partial class Index
    {
        List<SanPham> sp = null;
        public class SanPham
        {
            [Key]
            public int Masanpham { get; set; }

            [ForeignKey("QuanTris")]
            public int Maquantri { get; set; }

            [StringLength(250)]
            [Required(ErrorMessage = "Bạn cần nhập tên.")]
            [Display(Name = "Tên sản phẩm")]
            public string Tensanpham { get; set; }

            [Display(Name = "Mã loại")]
            [Required(ErrorMessage = "Bạn cần chọn mã loại."), Range(1, int.MaxValue, ErrorMessage = "Bạn cần chọn mã loại.")]
            [ForeignKey("LoaiSanPhams")]
            public int Maloai { get; set; }

            public int Soluong { get; set; }

            [Required(ErrorMessage = "Bạn cần nhập giá."), Range(0, double.MaxValue, ErrorMessage = "Bạn cần nhập giá.")]
            [Display(Name = "Giá")]
            public double Gia { get; set; }

            [StringLength(100)]
            [Display(Name = "Hình")]
            public string Hinh { get; set; }

            public int Soluotxem { get; set; }

            public DateTime Ngaynhap { get; set; }

            public int? Giamgia { get; set; }

            [StringLength(250)]
            [Display(Name = "Mô tả")]
            public string Mota { get; set; }

            [Display(Name = "Trạng thái")]
            public bool Trangthai { get; set; }

            public bool Dacbiet { get; set; }

        }
        protected override async Task OnInitializedAsync()
        {
            using (var client = new HttpClient())
            {
                var ss = await client.GetStringAsync("https://localhost:44356/api/sanphams/dssanpham");
                Console.WriteLine(ss);
                sp = JsonConvert.DeserializeObject<List<SanPham>>(ss);
            }
        }

    }
}

