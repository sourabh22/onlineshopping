#pragma checksum "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "953146c46b03a27513af2c724023603ce266c840"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductCart), @"mvc.1.0.view", @"/Views/Product/ProductCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ProductCart.cshtml", typeof(AspNetCore.Views_Product_ProductCart))]
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
#line 1 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\_ViewImports.cshtml"
using OnlineShoppingApplication;

#line default
#line hidden
#line 1 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
using OnlineShoppingApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"953146c46b03a27513af2c724023603ce266c840", @"/Views/Product/ProductCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d69418f4ffc406b4871284a682fb7cd88a946e5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductViewModelCart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProcessOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(86, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
  
    ViewData["Title"] = "ProductCart";
    var list = (List<ProductViewModelCart>)ViewData["products"];

#line default
#line hidden
            BeginContext(203, 24, true);
            WriteLiteral("\r\n<h2>ProductCart</h2>\r\n");
            EndContext();
            BeginContext(227, 1116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5611bfdb7fbc4f48b47bf4e64a2ee762", async() => {
                BeginContext(298, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
     for(var i=0;i<list.Count;i++)
    {

#line default
#line hidden
                BeginContext(343, 39, true);
                WriteLiteral("    <div>\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 382, "\"", 403, 3);
                WriteAttributeValue("", 389, "[", 389, 1, true);
#line 16 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
WriteAttributeValue("", 390, i, 390, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 392, "].ProductId", 392, 11, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 404, "\"", 430, 1);
#line 16 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
WriteAttributeValue("", 412, list[i].ProductId, 412, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(431, 20, true);
                WriteLiteral(" />\r\n        <label>");
                EndContext();
                BeginContext(452, 13, false);
#line 17 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
          Write(list[i].Title);

#line default
#line hidden
                EndContext();
                BeginContext(465, 29, true);
                WriteLiteral("</label> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 494, "\"", 511, 3);
                WriteAttributeValue("", 501, "[", 501, 1, true);
#line 17 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
WriteAttributeValue("", 502, i, 502, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 504, "].Title", 504, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 512, "\"", 534, 1);
#line 17 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
WriteAttributeValue("", 520, list[i].Title, 520, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(535, 20, true);
                WriteLiteral(" />\r\n        <label>");
                EndContext();
                BeginContext(556, 13, false);
#line 18 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
          Write(list[i].Price);

#line default
#line hidden
                EndContext();
                BeginContext(569, 29, true);
                WriteLiteral("</label> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 598, "\"", 615, 3);
                WriteAttributeValue("", 605, "[", 605, 1, true);
#line 18 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
WriteAttributeValue("", 606, i, 606, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 608, "].Price", 608, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 616, "\"", 638, 1);
#line 18 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
WriteAttributeValue("", 624, list[i].Price, 624, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(639, 20, true);
                WriteLiteral(" />\r\n        <label>");
                EndContext();
                BeginContext(660, 18, false);
#line 19 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
          Write(list[i].CategoryId);

#line default
#line hidden
                EndContext();
                BeginContext(678, 32, true);
                WriteLiteral("  </label>  <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 710, "\"", 732, 3);
                WriteAttributeValue("", 717, "[", 717, 1, true);
#line 19 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
WriteAttributeValue("", 718, i, 718, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 720, "].CategoryId", 720, 12, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 733, "\"", 760, 1);
#line 19 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
WriteAttributeValue("", 741, list[i].CategoryId, 741, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(761, 20, true);
                WriteLiteral(" />\r\n        <label>");
                EndContext();
                BeginContext(782, 21, false);
#line 20 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
          Write(list[i].SubCategoryId);

#line default
#line hidden
                EndContext();
                BeginContext(803, 31, true);
                WriteLiteral(" </label>  <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 834, "\"", 859, 3);
                WriteAttributeValue("", 841, "[", 841, 1, true);
#line 20 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
WriteAttributeValue("", 842, i, 842, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 844, "].SubCategoryId", 844, 15, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 860, "\"", 890, 1);
#line 20 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
WriteAttributeValue("", 868, list[i].SubCategoryId, 868, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(891, 20, true);
                WriteLiteral(" />\r\n        <select");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 911, "\"", 931, 3);
                WriteAttributeValue("", 918, "[", 918, 1, true);
#line 21 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"
WriteAttributeValue("", 919, i, 919, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 921, "].Quantity", 921, 10, true);
                EndWriteAttribute();
                BeginContext(932, 15, true);
                WriteLiteral(">\r\n            ");
                EndContext();
                BeginContext(947, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aea44403040345119ab3ae530f05c665", async() => {
                    BeginContext(965, 1, true);
                    WriteLiteral("1");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(975, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(989, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71be2160855049da8a46c1a12e2fa509", async() => {
                    BeginContext(1007, 1, true);
                    WriteLiteral("2");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1017, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1031, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c2eaae973a94adea48f364c3586e2f8", async() => {
                    BeginContext(1049, 1, true);
                    WriteLiteral("3");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1059, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1073, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1f1011db90a4641914bc1656ab5eece", async() => {
                    BeginContext(1091, 1, true);
                    WriteLiteral("4");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1101, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1115, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ad64eabee984765a8220ef291597b26", async() => {
                    BeginContext(1133, 1, true);
                    WriteLiteral("5");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1143, 107, true);
                WriteLiteral("\r\n        </select>\r\n        <button class=\"btn btn-success\" id=\"btnCart\">Remove</button>\r\n\r\n\r\n    </div>\r\n");
                EndContext();
#line 32 "D:\GitOnlineShopping\OnlineShoppingApplication\Views\Product\ProductCart.cshtml"

    }

#line default
#line hidden
                BeginContext(1259, 77, true);
                WriteLiteral("    <div>\r\n          <input type=\"submit\" value=\"Place Order\"/>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1343, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1378, 197, true);
                WriteLiteral("\r\n        <script>\r\n            $(\'button\').click(function (e) {\r\n                $(e.target).closest(\'div\').remove();\r\n                e.preventDefault();\r\n            });\r\n        </script>\r\n    ");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductViewModelCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
