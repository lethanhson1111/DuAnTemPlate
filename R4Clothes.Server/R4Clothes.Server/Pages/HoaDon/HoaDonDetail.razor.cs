using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using R4Clothes.Server.Pages.QuanTri;
using Microsoft.AspNetCore.Components;



namespace R4Clothes.Server.Pages.HoaDon
{
    public class SanPhamCT
    {

        public string TenSanPham { get; set; }
        public string Hinh { get; set; }
        public double Gia { get; set; }
        public int SoLuongMua { get; set; }

    }
    public partial class HoaDonDetail
    {
        [Parameter]
        public string id { get; set; }
        private string Tieude = "";
        //public SanPhamCT SanPhamCT = new SanPhamCT();
        //public HoaDon hoaDon = new HoaDon();
        private bool dense = false;
        private bool hover = true;
        private bool striped = false;
        private bool bordered = false;
        private string searchString1 = "";
        private string searchString2 = "";
        private SanPhamCT selectedItem1 = null;
        private SanPhamCT selectedItem2 = null;
        private HashSet<SanPhamCT> selectedItems = new HashSet<SanPhamCT>();
        public HoaDon hoaDon = new HoaDon();
        public IEnumerable<SanPhamCT> sanPhamCTs = new List<SanPhamCT>();

        protected override async Task OnInitializedAsync()
        {

            Tieude = "ct hóa đơn";
            //Thêm api getlsp/id
            sanPhamCTs = await httpClient.GetFromJsonAsync<List<SanPhamCT>>("/api/chitiethoadons/hoadon/" + id);
            hoaDon = await httpClient.GetFromJsonAsync<HoaDon>("api/HoaDons/" + id);


        }

        private bool FilterFunc1(SanPhamCT SanPhamCT) => FilterFunc(SanPhamCT, searchString1);
        private bool FilterFunc2(SanPhamCT SanPhamCT) => FilterFunc(SanPhamCT, searchString2);

        private bool FilterFunc(SanPhamCT SanPhamCT, string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (Convert.ToString(SanPhamCT.TenSanPham).Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{SanPhamCT.Gia}{SanPhamCT.SoLuongMua}".Contains(searchString))
                return true;
            return false;
        }
    }



}
