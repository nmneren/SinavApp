#pragma checksum "C:\Users\by_nu\source\repos\SinavApp23MartMvcCore\SinavApp23MartMvcCore\Views\Desing\ContentEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24c831705b0696978ac8f770823cbc8676e0a86a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Desing_ContentEkle), @"mvc.1.0.view", @"/Views/Desing/ContentEkle.cshtml")]
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
#nullable restore
#line 1 "C:\Users\by_nu\source\repos\SinavApp23MartMvcCore\SinavApp23MartMvcCore\Views\_ViewImports.cshtml"
using SinavApp23MartMvcCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\by_nu\source\repos\SinavApp23MartMvcCore\SinavApp23MartMvcCore\Views\_ViewImports.cshtml"
using SinavApp23MartMvcCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\by_nu\source\repos\SinavApp23MartMvcCore\SinavApp23MartMvcCore\Views\_ViewImports.cshtml"
using SinavApp23MartMvcCore.Models.ORM.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\by_nu\source\repos\SinavApp23MartMvcCore\SinavApp23MartMvcCore\Views\_ViewImports.cshtml"
using SinavApp23MartMvcCore.Models.ModelVM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24c831705b0696978ac8f770823cbc8676e0a86a", @"/Views/Desing/ContentEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65f74036b0f8eb7853dc1e0254fbe0b5ebc1538", @"/Views/_ViewImports.cshtml")]
    public class Views_Desing_ContentEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Menus>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Desing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ContentEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\by_nu\source\repos\SinavApp23MartMvcCore\SinavApp23MartMvcCore\Views\Desing\ContentEkle.cshtml"
  
    ViewData["Title"] = "ContentEkle";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h2>");
#nullable restore
#line 9 "C:\Users\by_nu\source\repos\SinavApp23MartMvcCore\SinavApp23MartMvcCore\Views\Desing\ContentEkle.cshtml"
       Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Ekle</h2>\r\n        <div class=\"row col-md-12\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24c831705b0696978ac8f770823cbc8676e0a86a5324", async() => {
                WriteLiteral("\r\n\r\n\r\n                <input type=\"hidden\" name=\"MenuId\"");
                BeginWriteAttribute("value", " value=\"", 324, "\"", 341, 1);
#nullable restore
#line 15 "C:\Users\by_nu\source\repos\SinavApp23MartMvcCore\SinavApp23MartMvcCore\Views\Desing\ContentEkle.cshtml"
WriteAttributeValue("", 332, Model.Id, 332, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />


                <div class=""form-group"">
                    <label>Adı</label> <br />
                    <input type=""text"" name=""Name"" style=""min-width:100%;"" class=""form-control"" />
                </div>

                <div class=""form-group"">
                    <label>Fiyati</label> <br />
                    <input type=""text"" name=""Price"" style=""min-width:100%;"" class=""form-control"" />
                </div>

                <div class=""form-group"">
                    <input type=""submit"" class=""btn btn-danger"" value=""Kaydet"" style=""min-width:100%;"" />
                </div>


            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Menus> Html { get; private set; }
    }
}
#pragma warning restore 1591