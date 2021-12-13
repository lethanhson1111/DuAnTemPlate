using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages.HoaDon
{
    public enum TrangthaiHD
    {
        [Display(Name = "Hủy")]
        Huy = -1,
        [Display(Name = "Đang chờ xử lí")]
        Dangchoxuli = 0,
        [Display(Name = "Đã xác nhận")]
        Daxacnhan = 1,
        [Display(Name = "Đang giao")]
        Danggiao = 2,
        [Display(Name = "Đã giao")]
        Dagiao = 3,
    }
    public class HoaDon
    {
        [Key]
        public int Mahoadon { get; set; }
        [Required]
        [ForeignKey("KhachHang")]
        public int Makhachhang { get; set; }
        [Required]
        [ForeignKey("QuanTri")]
        public int Nguoiquantri { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần nhập giá.")]
        [Display(Name = "Tổng tiền")]
        public double Tongtien { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Bạn cần chọn ngày."), Display(Name = "Ngày đặt")]
        public DateTime Ngaydat { get; set; }

        [Display(Name = "Trạng thái")]
        public TrangthaiHD Trangthai { get; set; }

        public KhachHang.KhachHang KhachHang { get; set; }
        public QuanTri.QuanTri QuanTri { get; set; }
        //public List<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
    public partial class HoaDonList
    {
        private string searchString1 = "";
        private string searchString2 = "";
        private HoaDon selectedItem1 = null;
        private HashSet<HoaDon> selectedItems = new HashSet<HoaDon>();

        public IEnumerable<HoaDon> HoaDons = new List<HoaDon>();

        protected override async Task OnInitializedAsync()
        {
            HoaDons = await httpClient.GetFromJsonAsync<List<HoaDon>>("api/QuanTris/hoadon/getall");
        }

        private bool FilterFunc1(HoaDon HoaDon) => FilterFunc(HoaDon, searchString1);
        private bool FilterFunc2(HoaDon HoaDon) => FilterFunc(HoaDon, searchString2);

        private bool FilterFunc(HoaDon HoaDon, string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (Convert.ToString(HoaDon.Ngaydat).Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{HoaDon.Mahoadon}{HoaDon.Makhachhang}{HoaDon.Nguoiquantri}".Contains(searchString))
                return true;
            return false;
        }
    }
}
