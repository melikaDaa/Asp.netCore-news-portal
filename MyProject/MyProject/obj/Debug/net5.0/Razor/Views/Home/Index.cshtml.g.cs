#pragma checksum "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad33a1f6f4d6001e19cf0ee16c31709f091a722d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\_ViewImports.cshtml"
using MyProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\_ViewImports.cshtml"
using MyProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad33a1f6f4d6001e19cf0ee16c31709f091a722d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6fe18bfd33a53b99196e5f743c625163e36f2af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyProject.Areas.Admin.Models.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/NewFolder/assets/images/dashboard/2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad33a1f6f4d6001e19cf0ee16c31709f091a722d5438", async() => {
                WriteLiteral("\r\n  <input type=\"search\" placeholder=\"لطفا عنوان خبر وارد نمایید\"");
                BeginWriteAttribute("value", " value=\"", 249, "\"", 284, 1);
#nullable restore
#line 8 "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 257, ViewData["GetNewsDetails"], 257, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"NewsSerach\" style=\"width:500px;\" />\r\n    <input type=\"submit\" value=\"Search\" class=\"btn btn-primary\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 13 "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\Home\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-body\">\r\n        <div class=\"row\">\r\n            <div class=\"col-3 grid-margin\">\r\n                <div class=\"rotate-img\">\r\n                    ");
#nullable restore
#line 19 "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.TitleCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad33a1f6f4d6001e19cf0ee16c31709f091a722d8336", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"  grid-margin\">\r\n                <h2 class=\"mb-2 font-weight-600\">\r\n                    ");
#nullable restore
#line 30 "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NewsName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </h2>\r\n\r\n                <div class=\"panel-body\">\r\n                  ");
#nullable restore
#line 35 "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\Home\Index.cshtml"
             Write(item.NewsDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <p class=\"mb-0\">\r\n                    ");
#nullable restore
#line 38 "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Author.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <div class=\"fs-13 mb-2\">\r\n                    <span class=\"mr-2\">\r\n                        ");
#nullable restore
#line 42 "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateTimeCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </span>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 50 "D:\New folder\Part1\Tamrin\MyProject\MyProject\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n<script>\r\n    $(function () {\r\n        $(\"basic-text1\").click(function () {\r\n            $(\"Form\").submit();\r\n        })\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyProject.Areas.Admin.Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
