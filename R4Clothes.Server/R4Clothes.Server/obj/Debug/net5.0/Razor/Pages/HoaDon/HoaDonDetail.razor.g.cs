#pragma checksum "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fee728255a88ffb276a97efb346e7426101cb666"
// <auto-generated/>
#pragma warning disable 1591
namespace R4Clothes.Server.Pages.HoaDon
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using R4Clothes.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using R4Clothes.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using CloudinaryDotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\_Imports.razor"
using CloudinaryDotNet.Actions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
using MudBlazor.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Hoadondetail/{id}")]
    public partial class HoaDonDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "﻿\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudText>(1);
            __builder.AddAttribute(2, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 10 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
               Typo.h6

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "Chi Tiết Hóa Đơn ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n<div class=\"flex-grow-1\"></div>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                  hoaDon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Dense", 
#nullable restore
#line 15 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                  dense

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "Hover", 
#nullable restore
#line 15 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                                 hover

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "Bordered", 
#nullable restore
#line 15 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                                                   bordered

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "Striped", 
#nullable restore
#line 15 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                                                                       striped

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "SelectedItem", 
#nullable restore
#line 15 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                                                                                                    selectedItem1

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "SelectedItemChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(15, "div");
                __builder2.AddMarkupContent(16, "<hr>\r\n        ");
                __builder2.OpenElement(17, "dl");
                __builder2.AddAttribute(18, "class", "row");
                __builder2.AddMarkupContent(19, "<dt class=\"col-sm-2\">Khách Hàng</dt>\r\n            ");
                __builder2.OpenElement(20, "dd");
                __builder2.AddAttribute(21, "class", "col-sm-10");
                __builder2.AddContent(22, 
#nullable restore
#line 20 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                   hoaDon.Mahoadon

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "dl");
                __builder2.AddAttribute(25, "class", "row");
                __builder2.AddMarkupContent(26, "<dt class=\"col-sm-2\">Ngày Đặt</dt>\r\n            ");
                __builder2.OpenElement(27, "dd");
                __builder2.AddAttribute(28, "class", "col-sm-10");
                __builder2.AddContent(29, 
#nullable restore
#line 24 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                   hoaDon.Makhachhang

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "dl");
                __builder2.AddAttribute(32, "class", "row");
                __builder2.AddMarkupContent(33, "<dt class=\"col-sm-2\">Tổng Tiền</dt>\r\n            ");
                __builder2.OpenElement(34, "dd");
                __builder2.AddAttribute(35, "class", "col-sm-10");
                __builder2.AddContent(36, 
#nullable restore
#line 28 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                   hoaDon.Nguoiquantri

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "dl");
                __builder2.AddAttribute(39, "class", "row");
                __builder2.AddMarkupContent(40, "<dt class=\"col-sm-2\">Trạng Thái</dt>\r\n            ");
                __builder2.OpenElement(41, "dd");
                __builder2.AddAttribute(42, "class", "col-sm-10");
                __builder2.AddContent(43, 
#nullable restore
#line 32 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                   hoaDon.Ngaydat

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "dl");
                __builder2.AddAttribute(46, "class", "row");
                __builder2.AddMarkupContent(47, "<dt class=\"col-sm-2\">Ghi Chú</dt>\r\n            ");
                __builder2.OpenElement(48, "dd");
                __builder2.AddAttribute(49, "class", "col-sm-10");
                __builder2.AddContent(50, 
#nullable restore
#line 36 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                   hoaDon.Tongtien

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenElement(52, "dl");
                __builder2.AddAttribute(53, "class", "row");
                __builder2.AddMarkupContent(54, "<dt class=\"col-sm-2\">Khách Hàng</dt>\r\n            ");
                __builder2.OpenElement(55, "dd");
                __builder2.AddAttribute(56, "class", "col-sm-10");
                __builder2.AddContent(57, 
#nullable restore
#line 40 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                   hoaDon.Trangthai

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n");
            __Blazor.R4Clothes.Server.Pages.HoaDon.HoaDonDetail.TypeInference.CreateMudTable_0(__builder, 59, 60, 
#nullable restore
#line 44 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                  sanPhamCTs

#line default
#line hidden
#nullable disable
            , 61, 
#nullable restore
#line 44 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                      dense

#line default
#line hidden
#nullable disable
            , 62, 
#nullable restore
#line 44 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                                     hover

#line default
#line hidden
#nullable disable
            , 63, 
#nullable restore
#line 44 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                                                       bordered

#line default
#line hidden
#nullable disable
            , 64, 
#nullable restore
#line 44 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                                                                           striped

#line default
#line hidden
#nullable disable
            , 65, 
#nullable restore
#line 44 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                                                                                            new Func<SanPhamCT,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 66, 
#nullable restore
#line 44 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                                                                                                                                                       selectedItem1

#line default
#line hidden
#nullable disable
            , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 68, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(69);
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(71, "Tên Sản Phẩm ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(73);
                __builder2.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(75, "Hình");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(77);
                __builder2.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(79, "Số Lượng ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(81);
                __builder2.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(83, " Giá");
                }
                ));
                __builder2.CloseComponent();
            }
            , 84, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(85);
                __builder2.AddAttribute(86, "DataLabel", "Maloai");
                __builder2.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(88, 
#nullable restore
#line 52 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                   context.TenSanPham

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(90);
                __builder2.AddAttribute(91, "DataLabel", "Tenloai");
                __builder2.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(93, 
#nullable restore
#line 53 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                    context.Hinh

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(95);
                __builder2.AddAttribute(96, "DataLabel", "Tenloai");
                __builder2.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(98, 
#nullable restore
#line 54 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                    context.SoLuongMua

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(100);
                __builder2.AddAttribute(101, "DataLabel", "Tenloai");
                __builder2.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(103, 
#nullable restore
#line 55 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonDetail.razor"
                                    context.Gia

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            , 104, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(105);
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
namespace __Blazor.R4Clothes.Server.Pages.HoaDon.HoaDonDetail
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Func<T, global::System.Boolean> __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Hover", __arg2);
        __builder.AddAttribute(__seq3, "Bordered", __arg3);
        __builder.AddAttribute(__seq4, "Striped", __arg4);
        __builder.AddAttribute(__seq5, "Filter", __arg5);
        __builder.AddAttribute(__seq6, "SelectedItem", __arg6);
        __builder.AddAttribute(__seq7, "SelectedItemChanged", __arg7);
        __builder.AddAttribute(__seq8, "HeaderContent", __arg8);
        __builder.AddAttribute(__seq9, "RowTemplate", __arg9);
        __builder.AddAttribute(__seq10, "PagerContent", __arg10);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
