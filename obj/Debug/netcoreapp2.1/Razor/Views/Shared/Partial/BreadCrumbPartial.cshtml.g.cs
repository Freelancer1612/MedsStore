<<<<<<< HEAD
#pragma checksum "C:\Users\ELCOT\Desktop\MedsStore\Views\Shared\Partial\BreadCrumbPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f56112284effabcff93a4ea4e9af1846bf0231"
=======
#pragma checksum "C:\Users\Gopivigneshkumar\source\MedsStore\Views\Shared\Partial\BreadCrumbPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f56112284effabcff93a4ea4e9af1846bf0231"
>>>>>>> c52d2bad1fc4ac974eedc37c8155098e3d355c5e
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial_BreadCrumbPartial), @"mvc.1.0.view", @"/Views/Shared/Partial/BreadCrumbPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial/BreadCrumbPartial.cshtml", typeof(AspNetCore.Views_Shared_Partial_BreadCrumbPartial))]
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
<<<<<<< HEAD
#line 1 "C:\Users\ELCOT\Desktop\MedsStore\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\Gopivigneshkumar\source\MedsStore\Views\_ViewImports.cshtml"
>>>>>>> c52d2bad1fc4ac974eedc37c8155098e3d355c5e
using MedsOnline;

#line default
#line hidden
<<<<<<< HEAD
#line 2 "C:\Users\ELCOT\Desktop\MedsStore\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\Gopivigneshkumar\source\MedsStore\Views\_ViewImports.cshtml"
>>>>>>> c52d2bad1fc4ac974eedc37c8155098e3d355c5e
using MedsOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f56112284effabcff93a4ea4e9af1846bf0231", @"/Views/Shared/Partial/BreadCrumbPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed8639d8283172c22cd0b1c782801d54d3c710e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial_BreadCrumbPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 342, true);
            WriteLiteral(@"<div class=""breadcrumbs ace-save-state"" id=""breadcrumbs"">
    <ul class=""breadcrumb"">
        <li>
            <i class=""ace-icon fa fa-home home-icon""></i>
            <a href=""#"">Home</a>
        </li>
        <li class=""active"">Blank Page</li>
    </ul><!-- /.breadcrumb -->

    <div class=""nav-search"" id=""nav-search"">
        ");
            EndContext();
            BeginContext(342, 304, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f56112284effabcff93a4ea4e9af1846bf02314192", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f56112284effabcff93a4ea4e9af1846bf02314222", async() => {
>>>>>>> c52d2bad1fc4ac974eedc37c8155098e3d355c5e
                BeginContext(368, 271, true);
                WriteLiteral(@"
            <span class=""input-icon"">
                <input type=""text"" placeholder=""Search ..."" class=""nav-search-input"" id=""nav-search-input"" autocomplete=""off"" />
                <i class=""ace-icon fa fa-search nav-search-icon""></i>
            </span>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(646, 43, true);
            WriteLiteral("\r\n    </div><!-- /.nav-search -->\r\n</div>\r\n");
            EndContext();
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
