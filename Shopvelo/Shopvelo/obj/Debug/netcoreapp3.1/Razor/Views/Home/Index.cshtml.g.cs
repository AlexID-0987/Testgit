#pragma checksum "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3459dfee8e7152566effb9fb0d9f7e4c1e98f39"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3459dfee8e7152566effb9fb0d9f7e4c1e98f39", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shopvelo.Models.Bake>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
  
    Layout = "_Layout";
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
      if(ViewBag.Thanks !=null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"display-1\" style=\"color:red;\">");
#nullable restore
#line 9 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
                                                     Write(ViewBag.Thanks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 10 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2>Bakes</h2>
    <table class=""table"" style=""background-color:white"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Model</th>
                <th>Color</th>
                <th>Time</th>
                <th>Price</th>
                <th>Foto</th>
                <th></th>
                

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
             foreach (var mybake in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
               Write(mybake.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
               Write(mybake.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
               Write(mybake.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
               Write(mybake.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
               Write(mybake.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <th>\r\n                    <div style=\"width:50px; height:50px\">\r\n                        <img");
            BeginWriteAttribute("src", " src=", 1025, "", 1042, 1);
#nullable restore
#line 37 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
WriteAttributeValue("", 1030, mybake.Foto, 1030, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\" />\r\n                    </div>\r\n                </th>\r\n                <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3459dfee8e7152566effb9fb0d9f7e4c1e98f396348", async() => {
                WriteLiteral("Buy");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1146, "~/Home/Buy/", 1146, 11, true);
#nullable restore
#line 40 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1157, mybake.BakeId, 1157, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Alex\source\repos\Shopvelo\Shopvelo\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shopvelo.Models.Bake>> Html { get; private set; }
    }
}
#pragma warning restore 1591