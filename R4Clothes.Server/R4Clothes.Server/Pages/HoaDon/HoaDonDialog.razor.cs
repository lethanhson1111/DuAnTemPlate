using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages.HoaDon
{
    public partial class HoaDonDialog
    {
        [Parameter]
        public string id { get; set; }
        public string nguoiql { get; set; }

        private string Tieude = "";
        public HoaDon hoaDon = new HoaDon();
        protected override async Task OnInitializedAsync()
        {
            if (string.IsNullOrWhiteSpace(id) || id == "0")
            {
                Tieude = "Thêm hóa đơn";
                hoaDon = new HoaDon();
            }
            else
            {
                Tieude = "Sửa hóa đơn";
                hoaDon = await httpClient.GetFromJsonAsync<HoaDon>("api/HoaDons/" + id);
            }
        }
        public async void SubmitForm()
        {
            //var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            //var accessToken = sessionStorage.GetItem<string>("AccessToken");
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            StringContent content = new StringContent(JsonConvert.SerializeObject(hoaDon),
            System.Text.Encoding.UTF8, "application/json");
            //httpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            HttpResponseMessage response = await httpClient.PostAsync("api/QuanTris/hoadon/suahd?idhd=" + id + "&nguoiql=" + 1 + "&tt=" + ((int)hoaDon.Trangthai), content);
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
                    navigation.NavigateTo("/hoadonlist");
                }
            }
        }
    }
}
