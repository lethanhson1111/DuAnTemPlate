using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages.KhachHang
{
    public partial class KhachhangDialog
    {
        [Parameter]
        public string id { get; set; }

        private string Tieude = "";
        public KhachHang khachHang = new KhachHang();
        protected override async Task OnInitializedAsync()
        {
            if (string.IsNullOrWhiteSpace(id) || id == "0")
            {
                Tieude = "Thêm khách hàng";
                khachHang = new KhachHang();
            }
            else
            {
                Tieude = "Sửa thông tin khách hàng";
                khachHang = await httpClient.GetFromJsonAsync<KhachHang>("api/khachhangs/" + id);
            }
        }
        public async void SubmitForm()
        {
            //var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            //var accessToken = sessionStorage.GetItem<string>("AccessToken");
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            StringContent content = new StringContent(JsonConvert.SerializeObject(khachHang),
            System.Text.Encoding.UTF8, "application/json");
            //httpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            if (string.IsNullOrWhiteSpace(id) || id == "0")
            {
                HttpResponseMessage response = await httpClient.PostAsync("api/KhachHangs", content);
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
                        navigation.NavigateTo("/khachhanglist");
                    }
                }
            }
            else
            {
                HttpResponseMessage response = await httpClient.PutAsync("api/KhachHangs/"+id, content);
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
                        navigation.NavigateTo("/khachhanglist");
                    }
                }
            }                     
        }
    }
}
