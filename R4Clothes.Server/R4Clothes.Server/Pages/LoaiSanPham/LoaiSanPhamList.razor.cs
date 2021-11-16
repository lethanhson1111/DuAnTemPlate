using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages.LoaiSanPham
{
    public class LoaiSanPham
    {
        [Key]
        public int Maloai { get; set; }
        [Display(Name = "Tên loại"), Required(ErrorMessage = "Bạn cần nhập tên."), StringLength(250)]
        public string Tenloai { get; set; }
    }
    public partial class LoaiSanPhamList
    {
        private bool dense = false;
        private bool hover = true;
        private bool striped = false;
        private bool bordered = false;
        private string searchString1 = "";
        private string searchString2 = "";
        private LoaiSanPham selectedItem1 = null;
        private LoaiSanPham selectedItem2 = null;
        private HashSet<LoaiSanPham> selectedItems = new HashSet<LoaiSanPham>();

        public IEnumerable<LoaiSanPham> LoaiSanPhams = new List<LoaiSanPham>();
        
        protected override async Task OnInitializedAsync()
        {
            LoaiSanPhams = await httpClient.GetFromJsonAsync<List<LoaiSanPham>>("api/LoaiSanPhams");
        }

        private bool FilterFunc1(LoaiSanPham loaiSanPham) => FilterFunc(loaiSanPham, searchString1);
        private bool FilterFunc2(LoaiSanPham loaiSanPham) => FilterFunc(loaiSanPham, searchString2);

        private bool FilterFunc(LoaiSanPham loaiSanPham, string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (loaiSanPham.Tenloai.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{loaiSanPham.Maloai}".Contains(searchString))
                return true;
            return false;
        }
    }
}
