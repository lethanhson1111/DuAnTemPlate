using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R4Clothes.Server.Pages.KhachHang
{
    public partial class KhachhangDialog
    {
        private string Tieude = "";
        public int IntValue { get; set; }
        bool _margin = true;
        bool _dense = true;
        public KhachHang khachHang = new KhachHang();
        public async void SubmitForm()
        {
        }
    }
}
