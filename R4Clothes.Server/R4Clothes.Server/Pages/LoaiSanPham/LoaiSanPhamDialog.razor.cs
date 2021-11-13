using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages.LoaiSanPham
{
    public partial class LoaiSanPhamDialog
    {
        [Parameter]
        public string id { get; set; }

        private string Tieude = "";
        public int IntValue { get; set; }
        bool _margin = true;
        bool _dense = true;
        public LoaiSanPham loaiSanPham = new LoaiSanPham();
        protected override async Task OnInitializedAsync()
        {
            if (string.IsNullOrWhiteSpace(id) || id == "0")
            {
                Tieude = "Thêm quản trị";
                loaiSanPham = new LoaiSanPham();
            }
            else
            {
                Tieude = "Sửa quản trị";
                //Thêm api getlsp/id
                loaiSanPham = await httpClient.GetFromJsonAsync<LoaiSanPham>("api/LoaiSanPham/get" + int.Parse(id));
            }
        }
        public async void SubmitForm()
        {
            if (loaiSanPham.Maloai == 0)
            {
                //quanTri = httpClient.PostAsJsonAsync<QuanTri>("api/QuanTris/add");
            }
            else
            {
                //quanTri = httpClient.PostAsJsonAsync<QuanTri>("api/QuanTris/edit/"+ int.Parse(id));
            }
            navigation.NavigateTo("LoaiSanPhamList");
        }
    }
}
