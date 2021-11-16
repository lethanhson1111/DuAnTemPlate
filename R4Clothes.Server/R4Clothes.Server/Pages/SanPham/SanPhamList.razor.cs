using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using R4Clothes.Server.Pages.LoaiSanPham;

namespace R4Clothes.Server.Pages.SanPham
{
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

        //public QuanTri QuanTris { get; set; }
        //public SanPham LoaiSanPhams { get; set; }
        //public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
    public partial class SanPhamList
    {
        private bool dense = false;
        private bool hover = true;
        private bool striped = false;
        private bool bordered = false;
        private string searchString1 = "";
        private string searchString2 = "";
        private SanPham selectedItem1 = null;
        private SanPham selectedItem2 = null;
        private HashSet<SanPham> selectedItems = new HashSet<SanPham>();
        public IEnumerable<SanPham> sanPhams = new List<SanPham>();
        
        protected override async Task OnInitializedAsync()
        {
            sanPhams = await httpClient.GetFromJsonAsync<List<SanPham>>("api/Sanphams/dssanpham");          
        }

        private bool FilterFunc1(SanPham element) => FilterFunc(element, searchString1);
        private bool FilterFunc2(SanPham element) => FilterFunc(element, searchString2);

        private bool FilterFunc(SanPham element, string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (element.Tensanpham.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{element.Maloai}".Contains(searchString))
                return true;
            return false;
        }
        
    }
}
