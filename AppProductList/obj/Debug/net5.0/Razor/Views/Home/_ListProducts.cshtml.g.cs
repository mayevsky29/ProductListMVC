#pragma checksum "C:\Users\Mayevsky\Desktop\AppProductList\AppProductList\Views\Home\_ListProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f9a8cb6d0ee8e24853e46f88c84ed405323c081"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ListProducts), @"mvc.1.0.view", @"/Views/Home/_ListProducts.cshtml")]
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
#line 1 "C:\Users\Mayevsky\Desktop\AppProductList\AppProductList\Views\_ViewImports.cshtml"
using AppProductList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mayevsky\Desktop\AppProductList\AppProductList\Views\_ViewImports.cshtml"
using AppProductList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f9a8cb6d0ee8e24853e46f88c84ed405323c081", @"/Views/Home/_ListProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a46a5ae6d6adfb4714067aea62421cbd7e6feebc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ListProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductAddViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Назва</th>
            <th scope=""col"">Ціна</th>
            <th scope=""col"">Фото</th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "C:\Users\Mayevsky\Desktop\AppProductList\AppProductList\Views\Home\_ListProducts.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 17 "C:\Users\Mayevsky\Desktop\AppProductList\AppProductList\Views\Home\_ListProducts.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\Mayevsky\Desktop\AppProductList\AppProductList\Views\Home\_ListProducts.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Mayevsky\Desktop\AppProductList\AppProductList\Views\Home\_ListProducts.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 572, "\"", 598, 2);
            WriteAttributeValue("", 578, "/images/", 578, 8, true);
#nullable restore
#line 21 "C:\Users\Mayevsky\Desktop\AppProductList\AppProductList\Views\Home\_ListProducts.cshtml"
WriteAttributeValue("", 586, item.Images, 586, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                         width=""150""
                         alt=""img"" />
                </td>
                <td class=""align-middle text-left""
                    style=""font-size: 30px"">

                    
                </td>
            </tr>
");
#nullable restore
#line 31 "C:\Users\Mayevsky\Desktop\AppProductList\AppProductList\Views\Home\_ListProducts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductAddViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
