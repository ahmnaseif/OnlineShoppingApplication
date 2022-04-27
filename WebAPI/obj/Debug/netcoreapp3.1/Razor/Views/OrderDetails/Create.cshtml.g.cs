#pragma checksum "C:\Users\DotTech\Desktop\Onlline Shop\OnlineShop\WebAPI\Views\OrderDetails\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "945a3adf55a7115cc1ef1bde316261013a53f1df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetails_Create), @"mvc.1.0.view", @"/Views/OrderDetails/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"945a3adf55a7115cc1ef1bde316261013a53f1df", @"/Views/OrderDetails/Create.cshtml")]
    public class Views_OrderDetails_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineShopDatabase.Models.OrderDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DotTech\Desktop\Onlline Shop\OnlineShop\WebAPI\Views\OrderDetails\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>OrderDetail</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""OrderDate"" class=""control-label""></label>
                <input asp-for=""OrderDate"" class=""form-control"" />
                <span asp-validation-for=""OrderDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CartId"" class=""control-label""></label>
                <select asp-for=""CartId"" class =""form-control"" asp-items=""ViewBag.CartId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""UserId"" class=""control-label""></label>
                <select asp-for=""UserId"" class =""form-control"" asp-items=""ViewBag.UserId""></select>
            </div>
            <div class=""form-group"">
                <label asp-");
            WriteLiteral(@"for=""PaymentType"" class=""control-label""></label>
                <input asp-for=""PaymentType"" class=""form-control"" />
                <span asp-validation-for=""PaymentType"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Amount"" class=""control-label""></label>
                <input asp-for=""Amount"" class=""form-control"" />
                <span asp-validation-for=""Amount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Discount"" class=""control-label""></label>
                <input asp-for=""Discount"" class=""form-control"" />
                <span asp-validation-for=""Discount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TotalPayable"" class=""control-label""></label>
                <input asp-for=""TotalPayable"" class=""form-control"" />
                <span asp-validation-for=""TotalPayable"" cla");
            WriteLiteral(@"ss=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\DotTech\Desktop\Onlline Shop\OnlineShop\WebAPI\Views\OrderDetails\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineShopDatabase.Models.OrderDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
