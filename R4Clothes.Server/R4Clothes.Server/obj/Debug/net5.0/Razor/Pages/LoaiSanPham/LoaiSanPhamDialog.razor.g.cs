#pragma checksum "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7fb4feff0924791b9ede9b6acbfba46e49c79ec"
// <auto-generated/>
#pragma warning disable 1591
namespace R4Clothes.Server.Pages.LoaiSanPham
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
#line 2 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
using MudBlazor.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LoaiSanPhamDialog/{id}")]
    public partial class LoaiSanPhamDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "﻿\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, 
#nullable restore
#line 11 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
     Tieude

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                  loaiSanPham

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                               SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(12);
                    __builder3.AddAttribute(13, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                    4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.R4Clothes.Server.Pages.LoaiSanPham.LoaiSanPhamDialog.TypeInference.CreateMudTextField_0(__builder4, 17, 18, 
#nullable restore
#line 16 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                  loaiSanPham.Maloai

#line default
#line hidden
#nullable disable
                        , 19, "Mã loại", 20, 
#nullable restore
#line 16 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                                                                true

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(22);
                    __builder3.AddAttribute(23, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                    4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.R4Clothes.Server.Pages.LoaiSanPham.LoaiSanPhamDialog.TypeInference.CreateMudTextField_1(__builder4, 27, 28, "Tên loại", 29, 
#nullable restore
#line 19 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                        loaiSanPham.Tenloai

#line default
#line hidden
#nullable disable
                        , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loaiSanPham.Tenloai = __value, loaiSanPham.Tenloai)));
                        __builder4.AddMarkupContent(31, "\r\n            ");
                        __Blazor.R4Clothes.Server.Pages.LoaiSanPham.LoaiSanPhamDialog.TypeInference.CreateValidationMessage_2(__builder4, 32, 33, 
#nullable restore
#line 20 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                      ()  => loaiSanPham.Tenloai

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "mt-3 ml-0 d-flex");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "d-flex ml-auto align-center");
                __builder2.OpenComponent<MudBlazor.MudButton>(39);
                __builder2.AddAttribute(40, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 25 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                                            Icons.Material.Filled.Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 25 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                                                                                    ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 25 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                                                                                                              Color.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "Class", "m-2");
                __builder2.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(46, "Save");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudButton>(48);
                __builder2.AddAttribute(49, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 26 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                                            Icons.Material.Filled.Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 26 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                                                                                 Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "Class", "m-2");
                __builder2.AddAttribute(53, "Link", "/LoaiSanPhamList");
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(55, "Hủy");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(57);
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(59);
                    __builder3.AddAttribute(60, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 30 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                     4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 30 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                            12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 31 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
             if (AlertSuccess == true)
            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudAlert>(63);
                        __builder4.AddAttribute(64, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 33 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                    Severity.Success

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(65, "Dense", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                                             true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(66, "Class", "my-2");
                        __builder4.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(68, "Dense Success");
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 34 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
            }
            else if (AlertError == true)
            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudAlert>(69);
                        __builder4.AddAttribute(70, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 37 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                    Severity.Error

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(71, "Dense", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
                                                           true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(72, "Class", "my-2");
                        __builder4.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(74, "Dense Error");
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 38 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
            }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\ACER\source\r4fe\DuAnTemPlate\R4Clothes.Server\R4Clothes.Server\Pages\LoaiSanPham\LoaiSanPhamDialog.razor"
      
    private void Reset()
    {
        loaiSanPham = new LoaiSanPham
        {
            Maloai = 0,
            Tenloai = null,
        };
        StateHasChanged();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
namespace __Blazor.R4Clothes.Server.Pages.LoaiSanPham.LoaiSanPhamDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Disabled", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
