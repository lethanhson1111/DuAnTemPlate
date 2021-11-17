using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages.LoaiSanPham
{
    public partial class LoaiSanPhamDialog
    {
        [Parameter]
        public string id { get; set; }

        private string Tieude = "";
        public LoaiSanPham loaiSanPham = new LoaiSanPham();
        protected override async Task OnInitializedAsync()
        {
            if (string.IsNullOrWhiteSpace(id) || id == "0")
            {
                Tieude = "Thêm loại sản phẩm";
                loaiSanPham = new LoaiSanPham();
            }
            else
            {
                navigation.NavigateTo("loaisanphamlist");
            }
        }
        public async void SubmitForm()
        {
            //var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            //var accessToken = sessionStorage.GetItem<string>("AccessToken");
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            StringContent content = new StringContent(JsonConvert.SerializeObject(loaiSanPham),
            System.Text.Encoding.UTF8, "application/json");
            //httpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            HttpResponseMessage response = await httpClient.PostAsync("api/loaiSanPhams", content);
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
                    navigation.NavigateTo("/loaisanphamlist");
                }
            }                  
        }
    }
}
