using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages.KhachHang
{
    public class KhachHang
    {
        [Key]
        public int Makhachhang { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Bạn cần nhập họ tên.")]
        [Display(Name = "Họ & Tên")]
        public string Tenkhachhang { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập email."), Display(Name = "Email")]
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Email không phù hợp.")]
        public string Email { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Bạn cần địa chỉ.")]
        [Display(Name = "Địa Chỉ")]
        public string Diachi { get; set; }

        public DateTime? Ngaysinh { get; set; }

        public int? Gioitinh { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập số điện thoại."), Display(Name = "Số điện thoại")]
        [Column(TypeName = "varchar(15)"), MaxLength(15)]
        [RegularExpression(@"^\(?([0-9]{3})[-. ]?([0-9]{4})[-. ]?([0-9]{3})$", ErrorMessage = "Số điện thoại không phù hợp.")]
        public string Sodienthoai { get; set; }

        [StringLength(100)]
        [Display(Name = "Hình")]
        public string? Hinh { get; set; }

        [Display(Name = "Trạng thái")]
        public bool? Trangthai { get; set; } = true;

        [Display(Name = "Mật khẩu")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Bạn cần nhập mật khẩu")]
        public string Matkhau { get; set; }
    }
    public partial class KhachHangList
    {
        private bool dense = false;
        private bool hover = true;
        private bool striped = false;
        private bool bordered = false;
        private string searchString1 = "";
        private string searchString2 = "";
        private KhachHang selectedItem1 = null;
        private KhachHang selectedItem2 = null;
        private HashSet<KhachHang> selectedItems = new HashSet<KhachHang>();

        public IEnumerable<KhachHang> khachHangs = new List<KhachHang>();

        protected override async Task OnInitializedAsync()
        {
            khachHangs = await httpClient.GetFromJsonAsync<List<KhachHang>>("api/Khachhangs/dskhachhang");
        }

        private bool FilterFunc1(KhachHang khachhang) => FilterFunc(khachhang, searchString1);
        private bool FilterFunc2(KhachHang khachhang) => FilterFunc(khachhang, searchString2);

        private bool FilterFunc(KhachHang khachhang, string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (khachhang.Tenkhachhang.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (khachhang.Email.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (khachhang.Diachi.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (khachhang.Sodienthoai.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{khachhang.Makhachhang}".Contains(searchString))
                return true;
            return false;
        }
    }
}
