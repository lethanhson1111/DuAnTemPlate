using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages.SanPham
{
    public partial class SanPhamDialog
    {
        [Parameter]
        public string id { get; set; }
        private string Tieude = "";
        
        //public interface IWebHostEnvironment env;
        IReadOnlyList<IBrowserFile> selectedFiles;
        public SanPham sanPham = new SanPham();
        protected override async Task OnInitializedAsync()
        {
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
            //if (selectedFiles != null && selectedFiles.Count > 0)
            //{
            //    var rootPath = $"{env.WebRootPath}\\images";
            //    if (!Directory.Exists(rootPath))
            //    {
            //        Directory.CreateDirectory(rootPath);
            //    }

            //    string dirPath = rootPath + @"\" + "SanPham";
            //    if (!Directory.Exists(dirPath))
            //    {
            //        Directory.CreateDirectory(dirPath);
            //    }

            //    var file = selectedFiles[0];
            //    string filePath = dirPath + @"\" + file.Name;
            //    //var path = $"{env.WebRootPath}\\images\\Monan\\{file.Name}";
            //    //foreach (var file in selectedFiles)
            //    {
            //        Stream stream = file.OpenReadStream();
            //        var path = $"{env.WebRootPath}\\images\\Monan\\{file.Name}";
            //        FileStream fs = File.Create(path);
            //        await stream.CopyToAsync(fs);
            //        stream.Close();
            //        fs.Close();
            //    }
            //    sanPham.Hinh = file.Name;
            //}
            //if (sanPham.Masanpham == 0)
            //{
            //    sanPham = await httpClient.PostAsJsonAsync<SanPham>("api/Sanphams/" + int.Parse(id));
            //}
            //else
            //{
            //    _monAnService.EditMonAn(monAn.MonAnID, monAn);
            //}
            //navigation.NavigateTo("MonanList");
        }
        private void Cancel()
        {
            navigation.NavigateTo("SanPhamList", true);
        }

        private void OnInputFileChange(InputFileChangeEventArgs e)
        {
            selectedFiles = e.GetMultipleFiles();
            //Message = $"{selectedFiles.Count} file(s) selected";
            this.StateHasChanged();
        }
    }
}
