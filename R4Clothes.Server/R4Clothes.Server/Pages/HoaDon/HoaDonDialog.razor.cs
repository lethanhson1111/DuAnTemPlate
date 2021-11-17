using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages.HoaDon
{
    public partial class HoaDonDialog
    {
        [Parameter]
        public string id { get; set; }

        private string Tieude = "";
        public HoaDon hoaDon = new HoaDon();
        protected override async Task OnInitializedAsync()
        {
            if (string.IsNullOrWhiteSpace(id) || id == "0")
            {

                navigation.NavigateTo("hoadonlist", true);
            }
            else
            {
                Tieude = "Sửa hóa đơn";
                //Thêm api getlsp/id
                hoaDon = await httpClient.GetFromJsonAsync<HoaDon>("api/hoadon/{id}" + int.Parse(id));
            }
        }
        public async void SubmitForm()
        {
            if (hoaDon.Mahoadon == 0)
            {
                //quanTri = httpClient.PostAsJsonAsync<QuanTri>("api/QuanTris/add");
            }
            else
            {
                //quanTri = httpClient.PostAsJsonAsync<QuanTri>("api/QuanTris/edit/"+ int.Parse(id));
            }
            navigation.NavigateTo("hoadonlist");
        }
    }
}
