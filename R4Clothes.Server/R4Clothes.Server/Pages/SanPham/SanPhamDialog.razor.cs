using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace R4Clothes.Server.Pages.SanPham
{
    public partial class SanPhamDialog
    {
        [Parameter]
        public string id { get; set; }
        private string Tieude = "";
        public string url;
        public string path;
        IList<IBrowserFile> files = new List<IBrowserFile>();      
        public SanPham sanPham = new SanPham();
        public IEnumerable<LoaiSanPham.LoaiSanPham> LoaiSanPhams = new List<LoaiSanPham.LoaiSanPham>();
        protected override async Task OnInitializedAsync()
        {
            LoaiSanPhams = await httpClient.GetFromJsonAsync<List<LoaiSanPham.LoaiSanPham>>("api/LoaiSanPhams");

            if (string.IsNullOrWhiteSpace(id) || id == "0")
            {
                Tieude = "Thêm sản phẩm";
                sanPham = new SanPham();
            }
            else
            {
                Tieude = "Sửa sản phẩm";
                sanPham = await httpClient.GetFromJsonAsync<SanPham>("api/Sanphams/" + int.Parse(id));
            }       
        }
        public async void SubmitForm()
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(sanPham),
            System.Text.Encoding.UTF8, "application/json");
            if (files != null && files.Count > 0)
            {               
            }
            if (sanPham.Masanpham == 0)
            {
                //test                
                HttpResponseMessage response = await httpClient.PostAsync("api/quantri/sanpham/add", content);               
                if (response.StatusCode != HttpStatusCode.OK)
                {
                }
                else
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (apiResponse == "-1")
                    {
                    }
                    else
                    {
                        navigation.NavigateTo("/sanphamlist");
                    }
                }
            }
            else
            {
                HttpResponseMessage response = await httpClient.PostAsync("api/quantri/sanpham/edit", content);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                }
                else
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (apiResponse == "-1")
                    {
                    }
                    else
                    {
                        navigation.NavigateTo("/sanphamlist");
                    }
                }
            }
            navigation.NavigateTo("sanphamlist");
        }
        private void Cancel()
        {
            navigation.NavigateTo("SanPhamList", true);
        }

        private async Task UploadFiles(InputFileChangeEventArgs e)
        {
            foreach (var item in e.GetMultipleFiles(2))
            {
                files.Add(item);
                url = await _uploadImage.GetUrlImage(item);
            }
            var file = files.FirstOrDefault();
            //TODO upload the files to the server
        }
    }
}
