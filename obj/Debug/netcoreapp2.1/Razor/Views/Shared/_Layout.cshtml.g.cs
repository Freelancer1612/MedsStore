#pragma checksum "C:\Users\Gopivigneshkumar\source\MedsStore\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0691de3e0d563daa0cf5fc8b22c26345dbcc0cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\Gopivigneshkumar\source\MedsStore\Views\_ViewImports.cshtml"
using MedsOnline;

#line default
#line hidden
#line 2 "C:\Users\Gopivigneshkumar\source\MedsStore\Views\_ViewImports.cshtml"
using MedsOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0691de3e0d563daa0cf5fc8b22c26345dbcc0cb", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed8639d8283172c22cd0b1c782801d54d3c710e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partial/NavBarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partial/SideBarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partial/BreadCrumbPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partial/SettingsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partial/FooterPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("no-skin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 923, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0691de3e0d563daa0cf5fc8b22c26345dbcc0cb5461", async() => {
                BeginContext(41, 199, true);
                WriteLiteral("\r\n    <meta http-equiv=\"Content-Security-Policy\" content=\"upgrade-insecure-requests\">\t\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge,chrome=1\" />\r\n    <meta charset=\"utf-8\" />\r\n    <title>");
                EndContext();
                BeginContext(241, 17, false);
#line 7 "C:\Users\Gopivigneshkumar\source\MedsStore\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(258, 53, true);
                WriteLiteral(" - MedsOnline</title>\r\n\r\n    <meta name=\"description\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 311, "\"", 321, 0);
                EndWriteAttribute();
                BeginContext(322, 629, true);
                WriteLiteral(@" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, maximum-scale=1.0"" />

    <!-- bootstrap & fontawesome -->
    <link rel=""stylesheet"" href=""/assets/css/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""/assets/font-awesome/4.5.0/css/font-awesome.min.css"" />
    
    <!-- text fonts -->
    <link rel=""stylesheet"" href=""/assets/css/fonts.googleapis.com.css"" />

    <!-- ace styles -->
    <link rel=""stylesheet"" href=""/assets/css/ace.min.css"" class=""ace-main-stylesheet"" id=""main-ace-style"" />
    <link rel=""stylesheet"" href=""/assets/css/ace-skins.min.css"" />
    
    
    
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(958, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(962, 3704, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0691de3e0d563daa0cf5fc8b22c26345dbcc0cb8149", async() => {
                BeginContext(984, 33, true);
                WriteLiteral("\r\n    <!-- Navbar Begin -->\r\n    ");
                EndContext();
                BeginContext(1017, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0691de3e0d563daa0cf5fc8b22c26345dbcc0cb8565", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1057, 276, true);
                WriteLiteral(@"
    <!-- Navbar End -->

    <div class=""main-container ace-save-state"" id=""main-container"">
        <script type=""text/javascript"">
            try { ace.settings.loadState('main-container') } catch (e) { }
        </script>

        <!-- Sidebar Begin -->
        ");
                EndContext();
                BeginContext(1333, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0691de3e0d563daa0cf5fc8b22c26345dbcc0cb10178", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1374, 177, true);
                WriteLiteral("\r\n        <!-- Sidebar End -->\r\n\r\n        <div class=\"main-content\">\r\n            <div class=\"main-content-inner\">\r\n\r\n                <!-- Breads Cum Begin -->\r\n                ");
                EndContext();
                BeginContext(1551, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0691de3e0d563daa0cf5fc8b22c26345dbcc0cb11704", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1595, 466, true);
                WriteLiteral(@"
                <!-- Breads Cum End -->

                <div class=""page-content"">
                    <div class=""ace-settings-container"" id=""ace-settings-container"">
                        <div class=""btn btn-app btn-xs btn-warning ace-settings-btn"" id=""ace-settings-btn"">
                            <i class=""ace-icon fa fa-cog bigger-130""></i>
                        </div>

                        <!-- Settings Begin -->
                        ");
                EndContext();
                BeginContext(2061, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0691de3e0d563daa0cf5fc8b22c26345dbcc0cb13514", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2103, 288, true);
                WriteLiteral(@"
                        <!-- Settings End -->

                    </div><!-- /.ace-settings-container -->

                    <div class=""row"">
                        <div class=""col-xs-12"">
                            <!-- PAGE CONTENT BEGINS -->
                            ");
                EndContext();
                BeginContext(2392, 12, false);
#line 63 "C:\Users\Gopivigneshkumar\source\MedsStore\Views\Shared\_Layout.cshtml"
                       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2404, 293, true);
                WriteLiteral(@"
                            <!-- PAGE CONTENT ENDS -->
                        </div><!-- /.col -->
                    </div><!-- /.row -->
                </div><!-- /.page-content -->
            </div>
        </div><!-- /.main-content -->

        <!-- Footer Begin -->
        ");
                EndContext();
                BeginContext(2697, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0691de3e0d563daa0cf5fc8b22c26345dbcc0cb15784", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2737, 1878, true);
                WriteLiteral(@"
        <!-- Footer End -->


        <a href=""#"" id=""btn-scroll-up"" class=""btn-scroll-up btn btn-sm btn-inverse"">
            <i class=""ace-icon fa fa-angle-double-up icon-only bigger-110""></i>
        </a>
    </div><!-- /.main-container -->
    <script src=""/assets/js/jquery-2.1.4.min.js""></script>
    <script type=""text/javascript"">
        if ('ontouchstart' in document.documentElement) document.write(""<script src='/assets/js/jquery.mobile.custom.min.js'>"" + ""<"" + ""/script>"");
    </script>
    <script src=""/assets/js/bootstrap.min.js""></script>
    <script src=""/assets/js/ace-elements.min.js""></script>
    <script src=""/assets/js/ace.min.js""></script>
    <script src=""/assets/js/ace-extra.min.js""></script>

    <!-- ######## -->
<script src=""/assets/js/jquery-2.1.4.min.js""></script>

		<!-- <![endif]-->

		<!--[if IE]>
<script src=""assets/js/jquery-1.11.3.min.js""></script>
<![endif]-->
		<script type=""text/javascript"">
			if('ontouchstart' in document.documentElement) document");
                WriteLiteral(@".write(""<script src='/assets/js/jquery.mobile.custom.min.js'>""+""<""+""/script>"");
		</script>
		<script src=""/assets/js/bootstrap.min.js""></script>

		<!-- page specific plugin scripts -->
		<script src=""/assets/js/jquery.dataTables.min.js""></script>
		<script src=""/assets/js/jquery.dataTables.bootstrap.min.js""></script>
		<script src=""/assets/js/dataTables.buttons.min.js""></script>
		<script src=""/assets/js/buttons.flash.min.js""></script>
		<script src=""/assets/js/buttons.html5.min.js""></script>
		<script src=""/assets/js/buttons.print.min.js""></script>
		<script src=""/assets/js/buttons.colVis.min.js""></script>
		<script src=""/assets/js/dataTables.select.min.js""></script>

		<!-- ace scripts -->
		<script src=""/assets/js/ace-elements.min.js""></script>
		<script src=""/assets/js/ace.min.js""></script>

    <!-- ######## -->
    ");
                EndContext();
                BeginContext(4616, 41, false);
#line 117 "C:\Users\Gopivigneshkumar\source\MedsStore\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(4657, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4666, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
