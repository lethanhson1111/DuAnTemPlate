using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages.QuanTri
{
    public class QuanTri
    {
        [Key]
        public int Maquantri { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Tài khoản")]
        [Required(ErrorMessage = "Bạn cần nhập tài khoản.")]
        public string Taikhoan { get; set; }

        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Bạn cần nhập họ tên.")]
        [Column(TypeName = "nvarchar(100)")]
        public string Hoten { get; set; }

        [Display(Name = "Mật khẩu")]
        [Column(TypeName = "varchar")]
        [DataType(DataType.Password)]
        [StringLength(50)]
        public string Matkhau { get; set; }
    }
    public partial class QuanTriList
    {
        private bool dense = false;
        private bool hover = true;
        private bool striped = false;
        private bool bordered = false;
        private string searchString1 = "";
        private string searchString2 = "";
        private QuanTri selectedItem1 = null;
        private QuanTri selectedItem2 = null;
        public HashSet<QuanTri> selectedItems = new HashSet<QuanTri>();
        public IEnumerable<QuanTri> quanTris = new List<QuanTri>();

        protected override async Task OnInitializedAsync()
        {
            quanTris = await httpClient.GetFromJsonAsync<List<QuanTri>>("api/QuanTris/dsqt");
        }

        private bool FilterFunc1(QuanTri quanTri) => FilterFunc(quanTri, searchString1);
        private bool FilterFunc2(QuanTri quanTri) => FilterFunc(quanTri, searchString2);

        private bool FilterFunc(QuanTri quanTri, string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (quanTri.Hoten.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (quanTri.Taikhoan.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{quanTri.Maquantri}".Contains(searchString))
                return true;
            return false;
        }
    }
}
