#pragma checksum "C:\Users\ELCOT\Desktop\MedsStore\Views\Shared\Partial\SideBarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54657d8094ec6f7fb6780b6580947396a4c804b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial_SideBarPartial), @"mvc.1.0.view", @"/Views/Shared/Partial/SideBarPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial/SideBarPartial.cshtml", typeof(AspNetCore.Views_Shared_Partial_SideBarPartial))]
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
#line 1 "C:\Users\ELCOT\Desktop\MedsStore\Views\_ViewImports.cshtml"
using MedsOnline;

#line default
#line hidden
#line 2 "C:\Users\ELCOT\Desktop\MedsStore\Views\_ViewImports.cshtml"
using MedsOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54657d8094ec6f7fb6780b6580947396a4c804b8", @"/Views/Shared/Partial/SideBarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed8639d8283172c22cd0b1c782801d54d3c710e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial_SideBarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PurchaseForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PurchaseDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1246, true);
            WriteLiteral(@"<div id=""sidebar"" class=""sidebar                  responsive                    ace-save-state"">
    <script type=""text/javascript"">
        try { ace.settings.loadState('sidebar') } catch (e) { }
    </script>

    <div class=""sidebar-shortcuts"" id=""sidebar-shortcuts"">
        <div class=""sidebar-shortcuts-large"" id=""sidebar-shortcuts-large"">
            <button class=""btn btn-success"">
                <i class=""ace-icon fa fa-signal""></i>
            </button>

            <button class=""btn btn-info"">
                <i class=""ace-icon fa fa-pencil""></i>
            </button>

            <button class=""btn btn-warning"">
                <i class=""ace-icon fa fa-users""></i>
            </button>

            <button class=""btn btn-danger"">
                <i class=""ace-icon fa fa-cogs""></i>
            </button>
        </div>

        <div class=""sidebar-shortcuts-mini"" id=""sidebar-shortcuts-mini"">
            <span class=""btn btn-success""></span>

            <span class=""btn bt");
            WriteLiteral("n-info\"></span>\r\n\r\n            <span class=\"btn btn-warning\"></span>\r\n\r\n            <span class=\"btn btn-danger\"></span>\r\n        </div>\r\n    </div><!-- /.sidebar-shortcuts -->\r\n\r\n    <ul class=\"nav nav-list\">\r\n        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1246, "\"", 1254, 0);
            EndWriteAttribute();
            BeginContext(1255, 193, true);
            WriteLiteral(">\r\n            <a href=\"#Dashboard\">\r\n                <i class=\"menu-icon fa fa-tachometer\"></i>\r\n                <span class=\"menu-text\"> Dashboard </span>\r\n            </a>\r\n        </li>\r\n\r\n");
            EndContext();
            BeginContext(1478, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1489, "\"", 1497, 0);
            EndWriteAttribute();
            BeginContext(1498, 379, true);
            WriteLiteral(@">
            <a href=""#"" class=""dropdown-toggle"">
                <i class=""menu-icon fa fa-shopping-cart""></i>
                <span class=""menu-text"">
                    Purchase
                </span>

                <b class=""arrow fa fa-angle-down""></b>
            </a>

            <b class=""arrow""></b>
            <ul class=""submenu"">
                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1877, "\"", 1885, 0);
            EndWriteAttribute();
            BeginContext(1886, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(1909, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54657d8094ec6f7fb6780b6580947396a4c804b87879", async() => {
                BeginContext(1964, 129, true);
                WriteLiteral("\r\n                        <i class=\"menu-icon fa fa-plus-square\"></i>\r\n                        Add Purchase\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2097, 89, true);
            WriteLiteral("\r\n                    <b class=\"arrow\"></b>\r\n                </li>\r\n\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2186, "\"", 2194, 0);
            EndWriteAttribute();
            BeginContext(2195, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(2218, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54657d8094ec6f7fb6780b6580947396a4c804b89924", async() => {
                BeginContext(2276, 131, true);
                WriteLiteral("\r\n                        <i class=\"menu-icon fa fa-hospital-o\"></i>\r\n                        Manage Purchase\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2411, 106, true);
            WriteLiteral("\r\n                    <b class=\"arrow\"></b>\r\n                </li>\r\n            </ul>\r\n        </li>\r\n\r\n\r\n");
            EndContext();
            BeginContext(2583, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2594, "\"", 2602, 0);
            EndWriteAttribute();
            BeginContext(2603, 119, true);
            WriteLiteral(">\r\n            <a href=\"#\" class=\"dropdown-toggle\">\r\n                <i class=\" menu-icon fa fa-user bigger-110\"></i>\r\n");
            EndContext();
            BeginContext(2782, 228, true);
            WriteLiteral("                <span class=\"menu-text\"> Customers </span>\r\n\r\n                <b class=\"arrow fa fa-angle-down\"></b>\r\n            </a>\r\n\r\n            <b class=\"arrow\"></b>\r\n\r\n            <ul class=\"submenu\">\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3010, "\"", 3018, 0);
            EndWriteAttribute();
            BeginContext(3019, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(3042, 195, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54657d8094ec6f7fb6780b6580947396a4c804b812805", async() => {
                BeginContext(3096, 137, true);
                WriteLiteral("\r\n                        <i class=\"menu-icon fa fa-caret-right\"></i>\r\n                        Customers Entry Form\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3237, 91, true);
            WriteLiteral("\r\n\r\n                    <b class=\"arrow\"></b>\r\n                </li>\r\n\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3328, "\"", 3336, 0);
            EndWriteAttribute();
            BeginContext(3337, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(3360, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54657d8094ec6f7fb6780b6580947396a4c804b814863", async() => {
                BeginContext(3415, 134, true);
                WriteLiteral("\r\n                        <i class=\"menu-icon fa fa-caret-right\"></i>\r\n                        Customers Details\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3553, 146, true);
            WriteLiteral("\r\n\r\n                    <b class=\"arrow\"></b>\r\n                </li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n    \r\n    <!-- /.nav-list -->\r\n");
            EndContext();
            BeginContext(3759, 379, true);
            WriteLiteral(@"

    <b class=""arrow""></b>
    </li>
    </ul>

    <!-- /.nav-list -->

    <div class=""sidebar-toggle sidebar-collapse"" id=""sidebar-collapse"">
        <i id=""sidebar-toggle-icon"" class=""ace-icon fa fa-angle-double-left ace-save-state""
            data-icon1=""ace-icon fa fa-angle-double-left"" data-icon2=""ace-icon fa fa-angle-double-right""></i>
    </div>
</div>
");
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
