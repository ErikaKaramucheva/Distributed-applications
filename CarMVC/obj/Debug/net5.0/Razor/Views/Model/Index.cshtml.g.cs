#pragma checksum "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c54b819691a1a47a51cbdeef930b54dac4de13eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Model_Index), @"mvc.1.0.view", @"/Views/Model/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\_ViewImports.cshtml"
using CarMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\_ViewImports.cshtml"
using CarMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c54b819691a1a47a51cbdeef930b54dac4de13eb", @"/Views/Model/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c0780ed8a87b80ef297575bc486aef67988026", @"/Views/_ViewImports.cshtml")]
    public class Views_Model_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<CarMVC.Models.ModelVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
#nullable restore
#line 5 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
   ViewBag.Title = "Модел на автомобила"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c54b819691a1a47a51cbdeef930b54dac4de13eb4603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<h2 class=\"text-center\">Модел на автомобила</h2>\n\n<br />\n<p class=\"text-center\">\n    ");
#nullable restore
#line 12 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
Write(Html.ActionLink("Добави нов модел", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n<br />\n");
#nullable restore
#line 15 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
 using (Html.BeginForm("Index", "Model", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-center\">\n    Потърси модел по име: ");
#nullable restore
#line 18 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
                     Write(Html.TextBox("SearchString", ViewBag.CurrentFilter as string));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <input type=\"submit\" value=\"Търсене\" />\n</p>");
#nullable restore
#line 20 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table text-center\">\n");
#nullable restore
#line 23 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <th>\n            Име на модела\n        </th>\n        <th>\n           Марка\n        </th>\n        <th>\n            Действие\n        </th>\n    </tr>\n");
#nullable restore
#line 37 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 41 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 44 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
   Write(item.BrandName(item.Brand_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 47 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
   Write(Html.ActionLink("Промени", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n        ");
#nullable restore
#line 48 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
   Write(Html.ActionLink("Детайли", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n        ");
#nullable restore
#line 49 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
   Write(Html.ActionLink("Изтрий", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>\n");
#nullable restore
#line 52 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
  }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>0 резултата</h3>\n");
#nullable restore
#line 56 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n<br />\nСтраница ");
#nullable restore
#line 59 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
     Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" от ");
#nullable restore
#line 59 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
                                                                    Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 60 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Model\Index.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page, currentFilter = ViewBag.CurrentFilter })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<CarMVC.Models.ModelVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
