#pragma checksum "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "266e2350406140045dd6cac7ab562a6eb5a4ce4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ratings), @"mvc.1.0.view", @"/Views/Home/Ratings.cshtml")]
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
#line 1 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\_ViewImports.cshtml"
using WebApplication9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\_ViewImports.cshtml"
using WebApplication9.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"266e2350406140045dd6cac7ab562a6eb5a4ce4f", @"/Views/Home/Ratings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"530e22d8e24f1a74566970b789dec6e4563d72e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Ratings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication9ML.Model.ModelInput>
    {
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
#line 2 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
  
    ViewData["Title"] = "Ratings";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
  
    var result = ViewBag.Result;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n\r\n    <hr />\r\n    <div class=\"container\">\r\n        <h4>     ");
#nullable restore
#line 13 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
            Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
                          Write(ViewBag.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "266e2350406140045dd6cac7ab562a6eb5a4ce4f4211", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 317, "~/ProductImg/", 317, 13, true);
#nullable restore
#line 14 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
AddHtmlAttributeValue("", 330, ViewBag.image, 330, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
      
        List<TblCustomerRatings> data = ViewBag.Comments;
        int count = 0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
       
        Dictionary<int, string> member = ViewBag.users;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive"">
        <table class=""table table-bordered bg-light"" id=""dataTable"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>Sr. No.</th>
                    <th>User</th>
                    <th>Comment</th>
                    <th>Rating</th>

                </tr>
            </thead>
            <tfoot>
                <tr>
                    <th>Sr. No.</th>
                    <th>User</th>
                    <th>Comment</th>
                    <th>Rating</th>
                </tr>
            </tfoot>
            <tbody>
");
#nullable restore
#line 44 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
                 if (data != null)
                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
                 foreach (var item in data)
                {
                    count = count + 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
                   Write(member[item.MemberId]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
                   Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 56 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
                         if (item.Rating > 3)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fa fa-arrow-up\" style=\"color:green\"></i>");
#nullable restore
#line 57 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
                                                                           }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa fa-arrow-down\" style=\"color:red\"></i>\r\n");
#nullable restore
#line 61 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 67 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n\r\n");
#nullable restore
#line 76 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
     using (Html.BeginForm("Ratings", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 85 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
       Write(Html.LabelFor(model => model.Comment, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 87 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
           Write(Html.EditorFor(model => model.Comment, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 88 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
           Write(Html.ValidationMessageFor(model => model.Comment, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 97 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"



    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-offset-4 col-md-4\">\r\n");
#nullable restore
#line 103 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
         if (result != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Result</h2>\r\n            <h3>Predection:");
#nullable restore
#line 106 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
                      Write(result.Prediction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>Score:");
#nullable restore
#line 107 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
                 Write(result.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 108 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Home\Ratings.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication9ML.Model.ModelInput> Html { get; private set; }
    }
}
#pragma warning restore 1591