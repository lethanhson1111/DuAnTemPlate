#pragma checksum "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e9df7f113b8e4cf2b1c20f336a6938dccac2559"
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
#line 2 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
using MudBlazor.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hoadonlist")]
    public partial class HoaDonList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "﻿\r\n");
            __Blazor.R4Clothes.Server.Pages.HoaDon.HoaDonList.TypeInference.CreateMudTable_0(__builder, 1, 2, 
#nullable restore
#line 8 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                  HoaDons

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 8 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                  true

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 8 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                new Func<HoaDon,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 8 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                                                                        selectedItem1

#line default
#line hidden
#nullable disable
            , 6, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 7, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(8);
                __builder2.AddAttribute(9, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 10 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "Danh Sách Loại Sản Phẩm");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        <div class=\"flex-grow-1\"></div>\r\n        ");
                __Blazor.R4Clothes.Server.Pages.HoaDon.HoaDonList.TypeInference.CreateMudTextField_1(__builder2, 13, 14, "Search", 15, 
#nullable restore
#line 13 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                                                  Adornment.Start

#line default
#line hidden
#nullable disable
                , 16, 
#nullable restore
#line 13 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                                                                                   Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 17, 
#nullable restore
#line 13 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                                                                                                                            MudBlazor.Size.Medium

#line default
#line hidden
#nullable disable
                , 18, "mt-0", 19, 
#nullable restore
#line 13 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                   searchString1

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            }
            , 21, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(22);
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(24, "Mã Hóa Đơn");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(26);
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "Mã Khách Hàng");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(30);
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(32, "Mã Quản Trị");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(34);
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(36, "Ngày Đặt");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(38);
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "Tổng Tiền");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(42);
                __builder2.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(44, "Trạng Thái");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(46);
                __builder2.CloseComponent();
            }
            , 47, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(48);
                __builder2.AddAttribute(49, "DataLabel", "Maloai");
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(51, 
#nullable restore
#line 25 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                   context.Mahoadon

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(53);
                __builder2.AddAttribute(54, "DataLabel", "Tenloai");
                __builder2.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(56, 
#nullable restore
#line 26 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                    context.Makhachhang

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(58);
                __builder2.AddAttribute(59, "DataLabel", "Tenloai");
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(61, 
#nullable restore
#line 27 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                    context.Nguoiquantri

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(63);
                __builder2.AddAttribute(64, "DataLabel", "Tenloai");
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(66, 
#nullable restore
#line 28 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                    context.Ngaydat

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(68);
                __builder2.AddAttribute(69, "DataLabel", "Tenloai");
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(71, 
#nullable restore
#line 29 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                    context.Tongtien

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(73);
                __builder2.AddAttribute(74, "DataLabel", "Tenloai");
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(76, 
#nullable restore
#line 30 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                    context.Trangthai

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(78);
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(80);
                    __builder3.AddAttribute(81, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 32 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(82, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                            Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 32 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                                                               Color.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(84, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 32 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                                                                                  MudBlazor.Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "Class", "m-2");
                    __builder3.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(87, "a");
                        __builder4.AddAttribute(88, "href", "/HoaDonDialog/" + (
#nullable restore
#line 32 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                                                                                                                                            context.Mahoadon

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(89, "Edit");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(91);
                    __builder3.AddAttribute(92, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 33 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                            Icons.Material.Filled.Details

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(94, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 33 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                                                                  Color.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(95, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 33 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                                                                                     MudBlazor.Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "Class", "m-2");
                    __builder3.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(98, "a");
                        __builder4.AddAttribute(99, "href", "/HoaDonDetail/" + (
#nullable restore
#line 33 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                                                                                                                                               context.Mahoadon

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(100, "Detail");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(102);
                    __builder3.AddAttribute(103, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 34 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(104, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                            Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(105, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 34 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\HoaDon\HoaDonList.razor"
                                                                                                 Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(106, "Class", "m-2");
                    __builder3.AddAttribute(107, "Link", "/LoaiSanPhamList");
                    __builder3.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(109, "Delete");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 110, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(111);
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
namespace __Blazor.R4Clothes.Server.Pages.HoaDon.HoaDonList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Func<T, global::System.Boolean> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Filter", __arg2);
        __builder.AddAttribute(__seq3, "SelectedItem", __arg3);
        __builder.AddAttribute(__seq4, "SelectedItemChanged", __arg4);
        __builder.AddAttribute(__seq5, "ToolBarContent", __arg5);
        __builder.AddAttribute(__seq6, "HeaderContent", __arg6);
        __builder.AddAttribute(__seq7, "RowTemplate", __arg7);
        __builder.AddAttribute(__seq8, "PagerContent", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Adornment __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Size __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Adornment", __arg1);
        __builder.AddAttribute(__seq2, "AdornmentIcon", __arg2);
        __builder.AddAttribute(__seq3, "IconSize", __arg3);
        __builder.AddAttribute(__seq4, "Class", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
