#pragma checksum "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bf53865a334bbf6afa34ec007f6e5bc341114b0"
// <auto-generated/>
#pragma warning disable 1591
namespace R4Clothes.Server.Pages.SanPham
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
#line 2 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
using MudBlazor.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sanphamlist")]
    public partial class SanPhamList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "???\r\n");
            __Blazor.R4Clothes.Server.Pages.SanPham.SanPhamList.TypeInference.CreateMudTable_0(__builder, 1, 2, 
#nullable restore
#line 8 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                  sanPhams

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 8 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                   true

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 8 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                 new Func<SanPham,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 8 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                                                                          selectedItem1

#line default
#line hidden
#nullable disable
            , 6, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 7, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(8);
                __builder2.AddAttribute(9, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 10 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "Danh S??ch S???n Ph???m");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        <div class=\"flex-grow-1\"></div>\r\n        ");
                __Blazor.R4Clothes.Server.Pages.SanPham.SanPhamList.TypeInference.CreateMudTextField_1(__builder2, 13, 14, "Search", 15, 
#nullable restore
#line 13 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                                                  Adornment.Start

#line default
#line hidden
#nullable disable
                , 16, 
#nullable restore
#line 13 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                                                                                   Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 17, 
#nullable restore
#line 13 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                                                                                                                            MudBlazor.Size.Medium

#line default
#line hidden
#nullable disable
                , 18, "mt-0 ml-3", 19, 
#nullable restore
#line 13 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                   searchString1

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            }
            , 21, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(22);
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(24, "IDSP");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(26);
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(28, "IDQT");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(30);
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(32, "T??n");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(34);
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(36, "Lo???i");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(38);
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(40, "SL");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(42);
                __builder2.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(44, "Gi??");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(46);
                __builder2.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(48, "H??nh");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(50);
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(52, "Ng??y nh???p");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(54);
                __builder2.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(56, "Gi???m gi??");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(58);
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(60, "M?? t???");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(62);
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(64, "Tr???ng th??i");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(66);
                __builder2.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(68, "?????c bi???t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(70);
                __builder2.CloseComponent();
            }
            , 71, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(72);
                __builder2.AddAttribute(73, "DataLabel", "Masanpham");
                __builder2.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(75, 
#nullable restore
#line 31 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                      context.Masanpham

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(77);
                __builder2.AddAttribute(78, "DataLabel", "Maquantri");
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(80, 
#nullable restore
#line 32 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                      context.Maquantri

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(82);
                __builder2.AddAttribute(83, "DataLabel", "Tensanpham");
                __builder2.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(85, 
#nullable restore
#line 33 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                       context.Tensanpham

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(87);
                __builder2.AddAttribute(88, "DataLabel", "Maloai");
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(90, 
#nullable restore
#line 34 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                   context.Maloai

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(92);
                __builder2.AddAttribute(93, "DataLabel", "Soluong");
                __builder2.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(95, 
#nullable restore
#line 35 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                    context.Soluong

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(97);
                __builder2.AddAttribute(98, "DataLabel", "Gia");
                __builder2.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(100, 
#nullable restore
#line 36 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                context.Gia

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(102);
                __builder2.AddAttribute(103, "DataLabel", "Hinh");
                __builder2.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(105, "img");
                    __builder3.AddAttribute(106, "src", "images/sanpham/" + (
#nullable restore
#line 38 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                          context.Hinh

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(107, "style", "width:150px");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(108, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(109);
                __builder2.AddAttribute(110, "DataLabel", "Ngaynhap");
                __builder2.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(112, 
#nullable restore
#line 39 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                     context.Ngaynhap

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(114);
                __builder2.AddAttribute(115, "DataLabel", "Giamgia");
                __builder2.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(117, 
#nullable restore
#line 40 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                    context.Giamgia

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(118, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(119);
                __builder2.AddAttribute(120, "DataLabel", "Mota");
                __builder2.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(122, 
#nullable restore
#line 41 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                 context.Mota

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(123, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(124);
                __builder2.AddAttribute(125, "DataLabel", "Trangthai");
                __builder2.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(127, 
#nullable restore
#line 42 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                      context.Trangthai

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(129);
                __builder2.AddAttribute(130, "DataLabel", "Dacbiet");
                __builder2.AddAttribute(131, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(132, 
#nullable restore
#line 43 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                    context.Dacbiet

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(133, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(134);
                __builder2.AddAttribute(135, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(136);
                    __builder3.AddAttribute(137, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 45 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(138, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                            Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(139, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 45 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                                                               Color.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(140, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 45 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                                                                                  MudBlazor.Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(141, "Class", "m-2");
                    __builder3.AddAttribute(142, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(143, "a");
                        __builder4.AddAttribute(144, "href", "/SanPhamDialog/" + (
#nullable restore
#line 45 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                                                                                                                                             context.Masanpham

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(145, "Edit");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(146, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(147);
                    __builder3.AddAttribute(148, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 46 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(149, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                            Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(150, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 46 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                                                                 Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(151, "Class", "m-2");
                    __builder3.AddAttribute(152, "Link", "/SanPhamList");
                    __builder3.AddAttribute(153, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(154, "Delete");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 155, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(156);
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(157, "\r\n\r\n");
            __builder.OpenElement(158, "div");
            __builder.AddAttribute(159, "class", "d-flex flex-wrap mt-4");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "style", "min-width:200px;");
            __builder.OpenComponent<MudBlazor.MudButton>(162);
            __builder.AddAttribute(163, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 56 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                            Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(164, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                        Icons.Material.Filled.CreateNewFolder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(165, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 56 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\SanPham\SanPhamList.razor"
                                                                                                      Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(166, "Class", "m-2");
            __builder.AddAttribute(167, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(168, "<a href=\"/SanPhamDialog/0\">Create</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
namespace __Blazor.R4Clothes.Server.Pages.SanPham.SanPhamList
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
