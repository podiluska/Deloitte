#pragma checksum "C:\italien\projects\Deloitte-Todo\Deloitte-Todo\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d634f0b3b8f1b14a4899d8efe7a6648526401a37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/Index.cshtml", typeof(AspNetCore.Views_Task_Index))]
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
#line 1 "C:\italien\projects\Deloitte-Todo\Deloitte-Todo\Views\_ViewImports.cshtml"
using Deloitte_Todo;

#line default
#line hidden
#line 2 "C:\italien\projects\Deloitte-Todo\Deloitte-Todo\Views\_ViewImports.cshtml"
using Deloitte_Todo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d634f0b3b8f1b14a4899d8efe7a6648526401a37", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60b557a6c3e9a94dec21b56a7aa827062ab5751d", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Deloitte.Todo.Models.TaskViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\italien\projects\Deloitte-Todo\Deloitte-Todo\Views\Task\Index.cshtml"
  
    ViewData["Title"] = "To Do";

#line default
#line hidden
            BeginContext(99, 34, true);
            WriteLiteral("\r\n<h2>To Do List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(133, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5448de3c27d4db4b2bca2bad2386868", async() => {
                BeginContext(153, 10, true);
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
            BeginContext(167, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(260, 47, false);
#line 16 "C:\italien\projects\Deloitte-Todo\Deloitte-Todo\Views\Task\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(307, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(363, 47, false);
#line 19 "C:\italien\projects\Deloitte-Todo\Deloitte-Todo\Views\Task\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastUpdated));

#line default
#line hidden
            EndContext();
            BeginContext(410, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(466, 46, false);
#line 22 "C:\italien\projects\Deloitte-Todo\Deloitte-Todo\Views\Task\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsComplete));

#line default
#line hidden
            EndContext();
            BeginContext(512, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\italien\projects\Deloitte-Todo\Deloitte-Todo\Views\Task\Index.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
            BeginContext(660, 26, false);
#line 30 "C:\italien\projects\Deloitte-Todo\Deloitte-Todo\Views\Task\Index.cshtml"
       Write(Html.DisplayFor(i => item));

#line default
#line hidden
            EndContext();
#line 30 "C:\italien\projects\Deloitte-Todo\Deloitte-Todo\Views\Task\Index.cshtml"
                                       
        }

#line default
#line hidden
            BeginContext(699, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Deloitte.Todo.Models.TaskViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
