#pragma checksum "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\Shared\WebLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1edc8fba5aa33af90dfedf61c19040d6651ca450"
// <auto-generated/>
#pragma warning disable 1591
namespace R4CloThes.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using R4CloThes.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using R4CloThes.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class WebLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<header><nav class=\"navbar navbar-expand-lg navbar-light bg-light\"><div class=\"container-fluid\"><a class=\"navbar-brand\" href=\"#\">R4CloThes Shop</a>\r\n            <button class=\"navbar-toggler\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#navbarSupportedContent\" aria-controls=\"navbarSupportedContent\" aria-expanded=\"false\" aria-label=\"Toggle navigation\"><span class=\"navbar-toggler-icon\"></span></button>\r\n            <div class=\"collapse navbar-collapse\" id=\"navbarSupportedContent\"><ul class=\"navbar-nav me-auto mb-2 mb-lg-0\"><li class=\"nav-item\"><a class=\"nav-link active\" aria-current=\"page\" href=\"#\">Trang Chủ</a></li>\r\n                    <li class=\"nav-item\"><a class=\"nav-link active\" href=\"#\">Giới Thiệu</a></li>\r\n                    <li class=\"nav-item dropdown\"><a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\">\r\n                            Dropdown\r\n                        </a>\r\n                        <ul class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\"><li><a class=\"dropdown-item\" href=\"#\">Action</a></li>\r\n                            <li><a class=\"dropdown-item\" href=\"#\">Another action</a></li>\r\n                            <li><hr class=\"dropdown-divider\"></li>\r\n                            <li><a class=\"dropdown-item\" href=\"#\">Something else here</a></li></ul></li></ul></div></div></nav>\r\n    <div id=\"carouselExampleControls\" class=\"carousel slide\" data-bs-ride=\"carousel\"><div class=\"carousel-inner\"><div class=\"carousel-item active\"><img height=\"450px\" src=\"https://3.bp.blogspot.com/---UAMa-25G4/WSZe9HYl3lI/AAAAAAAAD7A/o_KbF7Xr1uoth9DkC8nuMrD-QMg_hUyuACLcB/s1600/Trang-tri-shop-thoi-trang.jpg \" class=\"d-block w-100\" alt=\"...\"></div>\r\n            <div class=\"carousel-item\"><img height=\"450px\" src=\"https://thietkethicongshop.net/wp-content/uploads/2019/08/6F994CF0-FCCE-447E-A038-F98FA33CBAA4.jpg\" class=\"d-block w-100\" alt=\"...\"></div>\r\n            <div class=\"carousel-item\"><img height=\"450px\" src=\"https://thicongnhanh24h.com.vn/wp-content/uploads/2020/07/01-6-1024x755.jpg\" class=\"d-block w-100\" alt=\"...\"></div></div>\r\n        <button class=\"carousel-control-prev\" type=\"button\" data-bs-target=\"#carouselExampleControls\" data-bs-slide=\"prev\"><span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n            <span class=\"visually-hidden\">Previous</span></button>\r\n        <button class=\"carousel-control-next\" type=\"button\" data-bs-target=\"#carouselExampleControls\" data-bs-slide=\"next\"><span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n            <span class=\"visually-hidden\">Next</span></button></div></header>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "main");
            __builder.AddAttribute(4, "role", "main");
            __builder.AddAttribute(5, "class", "pb-3");
            __builder.AddContent(6, 
#nullable restore
#line 55 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4CloThes.Client\Shared\WebLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.AddMarkupContent(8, "<footer class=\"border-top footer text-muted\"><div class=\"container\"></div></footer>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591