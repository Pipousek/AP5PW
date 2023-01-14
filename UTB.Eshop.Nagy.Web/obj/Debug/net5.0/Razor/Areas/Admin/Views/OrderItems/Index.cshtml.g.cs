#pragma checksum "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb105a76d33336c83446b312f8da559f6af2db15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_OrderItems_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/OrderItems/Index.cshtml")]
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
#line 1 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
using UTB.Eshop.Nagy.Web.Models.Database.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb105a76d33336c83446b312f8da559f6af2db15", @"/Areas/Admin/Views/OrderItems/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8594b2ff5119f242021c20b389328864731462ce", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_OrderItems_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UTB.Eshop.Nagy.Web.Models.Entities.OrderItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
  
	string orderItemsCZEN, createNewItemCZEN;
	string buttonEdit, buttonDelete, buttonDetail;
	string amountCZEN, priceCZEN, orderCZEN, productCZEN;
	if (LanguageConfig.Language == "EN")
	{
		orderItemsCZEN = "Order items";
		createNewItemCZEN = "Create new order item";
		buttonEdit = "Edit";
		buttonDelete = "Delete";
		buttonDetail = "Details";
		amountCZEN = "Amount";
		priceCZEN = "Price";
		orderCZEN = "Order";
		productCZEN = "Product ID";
	}
	else
	{
		orderItemsCZEN = "Objednané položky";
		createNewItemCZEN = "Vytvořit novou objednávku položky";
		buttonEdit = "Upravit";
		buttonDelete = "Smazat";
		buttonDetail = "Podrobnosti";
		amountCZEN = "Množství";
		priceCZEN = "Cena";
		orderCZEN = "Objednávka";
		productCZEN = "ID Produktu";
	}

	ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 36 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
Write(orderItemsCZEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb105a76d33336c83446b312f8da559f6af2db156335", async() => {
#nullable restore
#line 39 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
                      Write(createNewItemCZEN);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t<!-- ");
#nullable restore
#line 45 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
                Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\r\n\t\t\t\t");
#nullable restore
#line 46 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
           Write(amountCZEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t<!-- ");
#nullable restore
#line 49 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
                Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\r\n\t\t\t\t");
#nullable restore
#line 50 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
           Write(priceCZEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t<!-- ");
#nullable restore
#line 53 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
                Write(Html.DisplayNameFor(model => model.Order));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\r\n\t\t\t\t");
#nullable restore
#line 54 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
           Write(orderCZEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t<!-- ");
#nullable restore
#line 57 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
                Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\r\n\t\t\t\t");
#nullable restore
#line 58 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
           Write(productCZEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th></th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 64 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 68 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 71 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 74 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Order.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 77 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Product.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb105a76d33336c83446b312f8da559f6af2db1511885", async() => {
#nullable restore
#line 80 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
                                                            Write(buttonEdit);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb105a76d33336c83446b312f8da559f6af2db1514311", async() => {
#nullable restore
#line 81 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
                                                               Write(buttonDetail);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
                                              WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb105a76d33336c83446b312f8da559f6af2db1516745", async() => {
#nullable restore
#line 82 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
                                                              Write(buttonDelete);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 85 "C:\Users\Petr\Documents\AP5PW\UTB.Eshop.Nagy.Web\UTB.Eshop.Nagy.Web\Areas\Admin\Views\OrderItems\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UTB.Eshop.Nagy.Web.Models.Entities.OrderItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591