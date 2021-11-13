using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages.QuanTri
{
    public partial class QuanTriDialog
    {
        [Parameter]
        public string id { get; set; }
        private string Tieude = "";
        public QuanTri quanTri = new QuanTri();
        protected override async Task OnInitializedAsync()
        {
            if (string.IsNullOrWhiteSpace(id) || id == "0")
            {
                Tieude = "Thêm quản trị";
                quanTri = new QuanTri();
            }
            else
            {
                Tieude = "Sửa quản trị";              
                quanTri = await httpClient.GetFromJsonAsync<QuanTri>("api/Quantris/get" + int.Parse(id));
            }
        }
        public async void SubmitForm()
        {
            if (quanTri.Maquantri == 0)
            {
                //quanTri = httpClient.PostAsJsonAsync<QuanTri>("api/QuanTris/add");
            }
            else
            {
                //quanTri = httpClient.PostAsJsonAsync<QuanTri>("api/QuanTris/edit/"+ int.Parse(id));
            }
            navigation.NavigateTo("QuanTriList");
        }
        private void Cancel()
        {
            navigation.NavigateTo("QuanTriList", true);
        }
    }
}
