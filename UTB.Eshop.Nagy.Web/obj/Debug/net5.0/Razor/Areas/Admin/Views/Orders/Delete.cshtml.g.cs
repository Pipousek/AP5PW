#pragma checksum "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "397c7ce22c0b153455688939c76af646bebd495f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Orders_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Orders/Delete.cshtml")]
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
#line 1 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\_ViewImports.cshtml"
using UTB.Eshop.Nagy.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\_ViewImports.cshtml"
using UTB.Eshop.Nagy.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\_ViewImports.cshtml"
using UTB.Eshop.Nagy.Web.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
using UTB.Eshop.Nagy.Web.Models.Database.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"397c7ce22c0b153455688939c76af646bebd495f", @"/Areas/Admin/Views/Orders/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8594b2ff5119f242021c20b389328864731462ce", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Orders_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UTB.Eshop.Nagy.Web.Models.Entities.Order>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
  
    string buttonDelete, buttonBack, confirmCZEN, orderCZEN;
    string dateTimeCZEN, orderNumberCZEN, totalPriceCZEN, userCZEN;

    if (LanguageConfig.Language == "EN")
	{
		buttonDelete = "Delete";
		buttonBack = "Back to list";
		confirmCZEN = "Are you sure you want to delete this?";
		orderCZEN = "Order";
        dateTimeCZEN = "Date and time of purchase";
        orderNumberCZEN = "Order number";
        totalPriceCZEN = "Total price";
        userCZEN = "User ID";
	}
	else
	{
		buttonDelete = "Smazat";
		buttonBack = "Zpět na seznam";
		confirmCZEN = "Jste si jistí, že chcete smazat tuto položku?";
		orderCZEN = "Objednávka";
        dateTimeCZEN = "Datum a čas vytvoření objednávky";
        orderNumberCZEN = "Číslo objednávky";
        totalPriceCZEN = "Celková cena";
        userCZEN = "ID uživatele";
	}
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 33 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
Write(buttonDelete);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<h3>");
#nullable restore
#line 35 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
Write(confirmCZEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<div>\n    <h4>");
#nullable restore
#line 37 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
   Write(orderCZEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            <!-- ");
#nullable restore
#line 41 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
            Write(Html.DisplayNameFor(model => model.DateTimeCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\n            ");
#nullable restore
#line 42 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
       Write(dateTimeCZEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 45 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateTimeCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            <!-- ");
#nullable restore
#line 48 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
            Write(Html.DisplayNameFor(model => model.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\n            ");
#nullable restore
#line 49 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
       Write(orderNumberCZEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 52 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            <!-- ");
#nullable restore
#line 55 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
            Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\n            ");
#nullable restore
#line 56 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
       Write(totalPriceCZEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 59 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            <!-- ");
#nullable restore
#line 62 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
            Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\n            ");
#nullable restore
#line 63 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
       Write(userCZEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 66 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.User.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd class>\n    </dl>\n    \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "397c7ce22c0b153455688939c76af646bebd495f10865", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "397c7ce22c0b153455688939c76af646bebd495f11130", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 71 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 2184, "\"", 2205, 1);
#nullable restore
#line 72 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
WriteAttributeValue("", 2192, buttonDelete, 2192, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "397c7ce22c0b153455688939c76af646bebd495f13328", async() => {
#nullable restore
#line 73 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\Orders\Delete.cshtml"
                         Write(buttonBack);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UTB.Eshop.Nagy.Web.Models.Entities.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
