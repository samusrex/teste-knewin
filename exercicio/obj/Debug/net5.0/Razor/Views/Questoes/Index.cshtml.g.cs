#pragma checksum "C:\teste knewin\exercicio\Views\Questoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35fc326b9e76aab41599abe1b8e13f104aaf05b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questoes_Index), @"mvc.1.0.view", @"/Views/Questoes/Index.cshtml")]
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
#line 1 "C:\teste knewin\exercicio\Views\_ViewImports.cshtml"
using exercicio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\teste knewin\exercicio\Views\_ViewImports.cshtml"
using exercicio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35fc326b9e76aab41599abe1b8e13f104aaf05b0", @"/Views/Questoes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7497c3d40584bdd8b1ccb0c105a22966e2e0b027", @"/Views/_ViewImports.cshtml")]
    public class Views_Questoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\teste knewin\exercicio\Views\Questoes\Index.cshtml"
  
    ViewData["Title"] = "Duplicado";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n        <div class=\"card-body\">\r\n    \r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35fc326b9e76aab41599abe1b8e13f104aaf05b03704", async() => {
                WriteLiteral(@"
           
            <div class=""form-group row"">
                <label for=""numeros"" class=""col-sm-2 col-form-label"">Lista de N??mero</label>
                <div class=""col-sm-8"">
                 <input type=""text"" readonly class=""form-control-plaintext"" id=""numeros"" value=""10,34,44,667,789,2,5,852,22,34,78,94,9857,0,6"">
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n</div>\r\n\r\n\r\n<div class=\"text-center\">\r\n   \r\n\r\n   \r\n\r\n<table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n        <th scope=\"col\">Elementos</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n       \r\n");
#nullable restore
#line 39 "C:\teste knewin\exercicio\Views\Questoes\Index.cshtml"
         foreach (var item in ViewBag.minha_lista)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr> <th>");
#nullable restore
#line 41 "C:\teste knewin\exercicio\Views\Questoes\Index.cshtml"
            Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> </tr>\r\n");
#nullable restore
#line 42 "C:\teste knewin\exercicio\Views\Questoes\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </tbody>\r\n</table>\r\n\r\n<div class=\"card\" style=\"background-color:#3399ff; \">\r\n<div class=\"card-body\">\r\n    <p style=\"color:#fff;\">O primeiro item duplicado na lista ??  ");
#nullable restore
#line 49 "C:\teste knewin\exercicio\Views\Questoes\Index.cshtml"
                                                            Write(ViewBag.teste);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n</div>\r\n</div>\r\n\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
