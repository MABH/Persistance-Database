#pragma checksum "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0c704a8a37c4a0d6eaa38b8b765d15ec0bc298e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleat_Index), @"mvc.1.0.view", @"/Views/Empleat/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empleat/Index.cshtml", typeof(AspNetCore.Views_Empleat_Index))]
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
#line 1 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\_ViewImports.cshtml"
using MySQL_Empleat;

#line default
#line hidden
#line 2 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\_ViewImports.cshtml"
using MySQL_Empleat.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c704a8a37c4a0d6eaa38b8b765d15ec0bc298e", @"/Views/Empleat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71ed7bc654870df20cf0edddac4bdff5976b19b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MySQL_Empleat.Models.Empleat>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(169, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eff1c6a01db450a8f5190613d73d095", async() => {
                BeginContext(192, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(206, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(299, 38, false);
#line 17 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(337, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(393, 39, false);
#line 20 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(432, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(488, 42, false);
#line 23 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cognom));

#line default
#line hidden
            EndContext();
            BeginContext(530, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(586, 42, false);
#line 26 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Carrec));

#line default
#line hidden
            EndContext();
            BeginContext(628, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(684, 39, false);
#line 29 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sou));

#line default
#line hidden
            EndContext();
            BeginContext(723, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(841, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(890, 37, false);
#line 38 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(927, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(983, 38, false);
#line 41 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1077, 41, false);
#line 44 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cognom));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1174, 41, false);
#line 47 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Carrec));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1271, 38, false);
#line 50 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sou));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1365, 121, false);
#line 53 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit",  new {  id=item.Id, nom=item.Nom, cognom=item.Cognom, carrec=item.Carrec, sou=item.Sou }));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1507, 58, false);
#line 54 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete",  new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1565, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Miguel Angel\source\repos\MySQL_Empleat\MySQL_Empleat\Views\Empleat\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1604, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MySQL_Empleat.Models.Empleat>> Html { get; private set; }
    }
}
#pragma warning restore 1591
