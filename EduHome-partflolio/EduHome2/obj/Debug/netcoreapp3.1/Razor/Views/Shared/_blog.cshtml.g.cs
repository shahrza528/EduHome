#pragma checksum "C:\Users\Shahrza\Desktop\Home works\ASP.NET\71_16-06-2021_download-to-excel-send-mail-shahrza528\EduHome2\Views\Shared\_blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e679c6efa6fb0874872bd418a4e531962cda9e67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__blog), @"mvc.1.0.view", @"/Views/Shared/_blog.cshtml")]
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
#line 1 "C:\Users\Shahrza\Desktop\Home works\ASP.NET\71_16-06-2021_download-to-excel-send-mail-shahrza528\EduHome2\Views\_ViewImports.cshtml"
using EduHome2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shahrza\Desktop\Home works\ASP.NET\71_16-06-2021_download-to-excel-send-mail-shahrza528\EduHome2\Views\_ViewImports.cshtml"
using EduHome2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shahrza\Desktop\Home works\ASP.NET\71_16-06-2021_download-to-excel-send-mail-shahrza528\EduHome2\Views\_ViewImports.cshtml"
using EduHome2.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e679c6efa6fb0874872bd418a4e531962cda9e67", @"/Views/Shared/_blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"827de6af52fc60049e1e2d1535ada02288aaa8f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\Shahrza\Desktop\Home works\ASP.NET\71_16-06-2021_download-to-excel-send-mail-shahrza528\EduHome2\Views\Shared\_blog.cshtml"
   int i = 0;
                int count = Model.Count; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shahrza\Desktop\Home works\ASP.NET\71_16-06-2021_download-to-excel-send-mail-shahrza528\EduHome2\Views\Shared\_blog.cshtml"
 foreach (var item in Model)
{
    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 240, "\"", 302, 3);
            WriteAttributeValue("", 248, "col-lg-4", 248, 8, true);
#nullable restore
#line 12 "C:\Users\Shahrza\Desktop\Home works\ASP.NET\71_16-06-2021_download-to-excel-send-mail-shahrza528\EduHome2\Views\Shared\_blog.cshtml"
WriteAttributeValue(" ", 256, count!=i?"col-md-6":"hidden-md", 257, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("  ", 291, "col-sm-12", 293, 11, true);
            EndWriteAttribute();
            WriteLiteral(">\n    <div class=\"card mt-5\">\n        <div class=\"media-5\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e679c6efa6fb0874872bd418a4e531962cda9e675426", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 385, "~/assets/image/", 385, 15, true);
#nullable restore
#line 15 "C:\Users\Shahrza\Desktop\Home works\ASP.NET\71_16-06-2021_download-to-excel-send-mail-shahrza528\EduHome2\Views\Shared\_blog.cshtml"
AddHtmlAttributeValue("", 400, item.image, 400, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""course-hover"">
                <i class=""fas fa-link""></i>
            </div>
            <div class=""overlay""></div>
        </div>

        <div class=""card-body"">
            <div class=""blog-top"">
                <p>
                    ");
#nullable restore
#line 25 "C:\Users\Shahrza\Desktop\Home works\ASP.NET\71_16-06-2021_download-to-excel-send-mail-shahrza528\EduHome2\Views\Shared\_blog.cshtml"
               Write(Html.Raw(item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n            </div>\n            <div class=\"blog-bottom\">\n                <h2>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 852, "\"", 859, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\Shahrza\Desktop\Home works\ASP.NET\71_16-06-2021_download-to-excel-send-mail-shahrza528\EduHome2\Views\Shared\_blog.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </h2>\n                <a");
            BeginWriteAttribute("href", " href=\"", 923, "\"", 930, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mybtn\">Read More</a>\n            </div>\n        </div>\n\n    </div>\n</div>            ");
#nullable restore
#line 37 "C:\Users\Shahrza\Desktop\Home works\ASP.NET\71_16-06-2021_download-to-excel-send-mail-shahrza528\EduHome2\Views\Shared\_blog.cshtml"
                  }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
