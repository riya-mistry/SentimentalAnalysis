#pragma checksum "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "945bcd6bccc5f5493a65b8ad773275bfda837616"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductEdit), @"mvc.1.0.view", @"/Views/Admin/ProductEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"945bcd6bccc5f5493a65b8ad773275bfda837616", @"/Views/Admin/ProductEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"530e22d8e24f1a74566970b789dec6e4563d72e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProductEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication9.Models.TblProduct>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
  
    ViewData["Title"] = "ProductEdit";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
     using (Html.BeginForm("ProductEdit", "Admin", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h4>Product</h4>\r\n            <hr />\r\n            ");
#nullable restore
#line 17 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
       Write(Html.HiddenFor(model => model.ProductId, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
               Write(Html.LabelFor(model => model.ProductName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
                   Write(Html.EditorFor(model => model.ProductName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 24 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.ProductName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n\r\n");
#nullable restore
#line 30 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
                  
                    List<SelectListItem> data = ViewBag.CategoryList;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
               Write(Html.LabelFor(model => model.CategoryId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
                   Write(Html.DropDownListFor(model => model.CategoryId, data, "---Select---", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 37 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.CategoryId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 44 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
           Write(Html.LabelFor(model => model.IsActive, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 47 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
                   Write(Html.CheckBox("IsActive"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 48 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.IsActive, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 53 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
   Write(Html.HiddenFor(model => model.IsDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6\">\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 59 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
           Write(Html.LabelFor(model => model.ProductImage, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n\r\n                    <input type=\"file\" name=\"file\" id=\"file\" style=\"width: 100%;\" />\r\n                    ");
#nullable restore
#line 63 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
               Write(Html.ValidationMessageFor(model => model.ProductImage, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 70 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
           Write(Html.LabelFor(model => model.IsFeatured, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 72 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
               Write(Html.CheckBox("IsFeatured"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 73 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
               Write(Html.ValidationMessageFor(model => model.IsFeatured, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"col-md-6\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 80 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
           Write(Html.LabelFor(model => model.Quantity, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 82 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
               Write(Html.EditorFor(model => model.Quantity, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 83 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Quantity, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 89 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
           Write(Html.LabelFor(model => model.Price, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 91 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
               Write(Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 92 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
                </div>
            </div>
        </div>
");
#nullable restore
#line 103 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\ProductEdit.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication9.Models.TblProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591