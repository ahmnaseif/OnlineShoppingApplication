#pragma checksum "C:\Users\DotTech\Desktop\Onlline Shop\OnlineShop\WebAPI\Views\Carts\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a2d027ded34ff03768285b12e7e6de4f1b8104a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carts_Edit), @"mvc.1.0.view", @"/Views/Carts/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a2d027ded34ff03768285b12e7e6de4f1b8104a", @"/Views/Carts/Edit.cshtml")]
    public class Views_Carts_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineShopDatabase.Models.Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DotTech\Desktop\Onlline Shop\OnlineShop\WebAPI\Views\Carts\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Cart</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""CartId"" />
            <div class=""form-group"">
                <label asp-for=""ProductId"" class=""control-label""></label>
                <select asp-for=""ProductId"" class=""form-control"" asp-items=""ViewBag.ProductId""></select>
                <span asp-validation-for=""ProductId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductCount"" class=""control-label""></label>
                <input asp-for=""ProductCount"" class=""form-control"" />
                <span asp-validation-for=""ProductCount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductPrice"" class=""control-label""></label>
                <input asp-for=""Produc");
            WriteLiteral(@"tPrice"" class=""form-control"" />
                <span asp-validation-for=""ProductPrice"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
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
#line 43 "C:\Users\DotTech\Desktop\Onlline Shop\OnlineShop\WebAPI\Views\Carts\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineShopDatabase.Models.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
