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

namespace R4Clothes.Server.Pages.QuanTri
{
    public partial class QuanTriDialog
    {
        [Parameter]
        public string id { get; set; }
        bool flag = true;
        private string Tieude = "";
        public QuanTri quantri = new QuanTri();
        protected override async Task OnInitializedAsync()
        {
            if (string.IsNullOrWhiteSpace(id) || id == "0")
            {
                Tieude = "Thêm quản trị";
                quantri = new QuanTri();
            }
            else
            {
                Tieude = "Sửa thông tin quản trị";
                quantri = await httpClient.GetFromJsonAsync<QuanTri>("api/QuanTris/get/" + id);
            }
        }
        public async void SubmitForm()
        {
            //var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            //var accessToken = sessionStorage.GetItem<string>("AccessToken");
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            StringContent content = new StringContent(JsonConvert.SerializeObject(quantri),
            System.Text.Encoding.UTF8, "application/json");
            //httpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            if (string.IsNullOrWhiteSpace(id) || id == "0")
            {
                HttpResponseMessage response = await httpClient.PostAsync("api/QuanTris/add", content);

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
                        navigation.NavigateTo("/quantrilist");
                    }
                }
            }
            else
            {               
                flag = false;
                HttpResponseMessage response = await httpClient.PostAsync("api/QuanTris/edit/" + id, content);
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
                        navigation.NavigateTo("/quantrilist");
                    }
                }
            }
        }
        private string PasswordMatch(string arg)
        {
            if (pwField1.Value != arg)
                return "mật khẩu không trùng";
            return null;
        }
    }
}
