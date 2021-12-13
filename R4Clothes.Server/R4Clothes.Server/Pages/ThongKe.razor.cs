using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages
{
    public class KhachHangTT
    {
        public string TenKhachHang { get; set; }
        public string EmailKhachHang { get; set; }
        public string SDT { get; set; }
        public int SoHoaDon { get; set; }
    }
    public partial class ThongKe
    {
        DateTime? from = DateTime.Today;
        DateTime? to = DateTime.Today;
        public DateTime? tu { get; set; }
        public DateTime? den { get; set; }
        public IEnumerable<HoaDon.HoaDon> DoanhThus = new List<HoaDon.HoaDon>();
        public IEnumerable<KhachHangTT> KhachHangs = new List<KhachHangTT>();
        public IEnumerable<SanPham.SanPham> BanDuoc = new List<SanPham.SanPham>();

        protected override async Task OnInitializedAsync()
        {
            DoanhThus = await httpClient.GetFromJsonAsync<List<HoaDon.HoaDon>>("api/thongke/doanhthu?from=" + from + "&to=" + to);
            KhachHangs = await httpClient.GetFromJsonAsync<List<KhachHangTT>>("api/thongke/specialcus");
            BanDuoc = await httpClient.GetFromJsonAsync<List<SanPham.SanPham>>("api/thongke/banduoc");
        }
        public async void tim()
        {
            DoanhThus = await httpClient.GetFromJsonAsync<List<HoaDon.HoaDon>>("api/thongke/doanhthu?from=" + tu + "&to=" + den);
        }
    }
}
