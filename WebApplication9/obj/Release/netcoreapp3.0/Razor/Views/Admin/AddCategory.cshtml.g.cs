#pragma checksum "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fde316f9c465bdf5d1bcf7cae9a45ebbda13fcac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddCategory), @"mvc.1.0.view", @"/Views/Admin/AddCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde316f9c465bdf5d1bcf7cae9a45ebbda13fcac", @"/Views/Admin/AddCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"530e22d8e24f1a74566970b789dec6e4563d72e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication9.Models.TblCategory>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
  
    ViewData["Title"] = "AddCategory";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
         using (Html.BeginForm("AddCategory", "Admin", FormMethod.Post, new { enctype = "multipart/form-data" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-horizontal\">\r\n                <h4>Category</h4>\r\n                <hr />\r\n                ");
#nullable restore
#line 15 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 16 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
           Write(Html.HiddenFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 19 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
               Write(Html.LabelFor(model => model.CategoryName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
                   Write(Html.EditorFor(model => model.CategoryName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 22 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
                   Write(Html.ValidationMessageFor(model => model.CategoryName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
               Write(Html.LabelFor(model => model.IsActive, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
                   Write(Html.CheckBox("IsActive"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 30 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
                   Write(Html.ValidationMessageFor(model => model.IsActive, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
               Write(Html.LabelFor(model => model.IsDelete, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 37 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
                   Write(Html.CheckBox("IsDelete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 38 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
                   Write(Html.ValidationMessageFor(model => model.IsDelete, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>

                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" value=""Save"" class=""btn btn-default"" />
                    </div>
                </div>
            </div>
");
#nullable restore
#line 48 "C:\Users\lenovo\source\repos\WebApplication9\WebApplication9\Views\Admin\AddCategory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication9.Models.TblCategory> Html { get; private set; }
    }
}
#pragma warning restore 1591
