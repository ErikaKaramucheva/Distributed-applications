#pragma checksum "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eddecc25bd9442457c24bbcf3b386d4f23f62a6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Details___Copy), @"mvc.1.0.view", @"/Views/Car/Details - Copy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eddecc25bd9442457c24bbcf3b386d4f23f62a6d", @"/Views/Car/Details - Copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c0780ed8a87b80ef297575bc486aef67988026", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Details___Copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarMVC.Models.CarVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
   ViewData["Title"] = "Детайли"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-center\">Детайли</h1>\n\n<div>\n    <h4 class=\"text-center\">Детайли</h4>\n    <hr />\n    <dl class=\"row text-center\">\n        <dt class=\"col-sm-2 text-center\">\n            Модел на автомобила:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 14 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Model.ModelName(Model.Model_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Марка на автомобила:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 19 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Model.BrandName(Model.Brand_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Цвят на автомобила:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 24 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Цена:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 29 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Километри:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 34 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Html.DisplayFor(model => model.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Година на производство:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 39 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Гориво:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 44 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Model.FuelName(Model.Fuel_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Клас:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 49 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Model.ClassName(Model.Class_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Клас:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 54 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Model.ClassName(Model.CarStatus_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Трансмисия:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 59 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Model.TransmissionName(Model.Transmission_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n\n        <dt class=\"col-sm-2 text-center\">\n            Статус:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 66 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Model.StatusName(Model.CarStatus_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Описание:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 71 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Изображение:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 76 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Html.DisplayFor(model => model.ImageURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Град:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 81 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Model.TownName(Model.Town_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Телефон за връзка:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 86 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Model.GetUserPhone(Model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-center\">\n            Имейл:\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 91 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Model.GetUserEmail(Model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Създаден на:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 97 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Convert.ToDateTime(@Model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Последна промяна:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 103 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Convert.ToDateTime(@Model.UpdatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Създаден от:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 109 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Model.UserName(Model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Променен от:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 115 "C:\Users\user\Desktop\Distributed Applications\CarMVC\Views\Car\Details - Copy.cshtml"
       Write(Model.UserName(Model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n    </dl>\n</div>\n<div class=\"justify-content-center\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eddecc25bd9442457c24bbcf3b386d4f23f62a6d11541", async() => {
                WriteLiteral("Назад");
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
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarMVC.Models.CarVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
