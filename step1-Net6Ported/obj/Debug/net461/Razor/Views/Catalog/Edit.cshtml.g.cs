#pragma checksum "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dd093c556b860a9e26b6823d091ea008641e5d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Edit), @"mvc.1.0.view", @"/Views/Catalog/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Edit.cshtml", typeof(AspNetCore.Views_Catalog_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dd093c556b860a9e26b6823d091ea008641e5d4", @"/Views/Catalog/Edit.cshtml")]
    public class Views_Catalog_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eShopPorted.Models.CatalogItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
            BeginContext(72, 40, true);
            WriteLiteral("\n<h2 class=\"esh-body-title\">Edit</h2>\n\n\n");
            EndContext();
#line 10 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(145, 23, false);
#line 12 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(169, 99, true);
            WriteLiteral("    <div class=\"container\">\n        <div class=\"row\">\n            <img class=\"col-md-6 esh-picture\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 268, "\"", 291, 1);
#line 15 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
WriteAttributeValue("", 274, Model.PictureUri, 274, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(292, 71, true);
            WriteLiteral(" />\n            <div class=\"col-md-6 form-horizontal\">\n                ");
            EndContext();
            BeginContext(364, 64, false);
#line 17 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(428, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(446, 33, false);
#line 18 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
           Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(479, 63, true);
            WriteLiteral("\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(543, 93, false);
#line 21 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
               Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(636, 68, true);
            WriteLiteral("\n                    <div class=\"col-md-8\">\n                        ");
            EndContext();
            BeginContext(705, 93, false);
#line 23 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(798, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(824, 82, false);
#line 24 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(906, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(1020, 100, false);
#line 29 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
               Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 68, true);
            WriteLiteral("\n                    <div class=\"col-md-8\">\n                        ");
            EndContext();
            BeginContext(1189, 100, false);
#line 31 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(1315, 89, false);
#line 32 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(1518, 121, false);
#line 37 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
               Write(Html.LabelFor(model => model.CatalogBrandId, "CatalogBrandId", htmlAttributes: new { @class = "control-label col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 68, true);
            WriteLiteral("\n                    <div class=\"col-md-8\">\n                        ");
            EndContext();
            BeginContext(1708, 90, false);
#line 39 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.DropDownList("CatalogBrandId", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1798, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(1824, 92, false);
#line 40 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.CatalogBrandId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1916, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(2030, 119, false);
#line 45 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
               Write(Html.LabelFor(model => model.CatalogTypeId, "CatalogTypeId", htmlAttributes: new { @class = "control-label col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(2149, 68, true);
            WriteLiteral("\n                    <div class=\"col-md-8\">\n                        ");
            EndContext();
            BeginContext(2218, 89, false);
#line 47 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.DropDownList("CatalogTypeId", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2307, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2333, 91, false);
#line 48 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.CatalogTypeId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2424, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(2538, 94, false);
#line 53 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
               Write(Html.LabelFor(model => model.Price, htmlAttributes: new { @class = "control-label col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(2632, 68, true);
            WriteLiteral("\n                    <div class=\"col-md-8\">\n                        ");
            EndContext();
            BeginContext(2701, 94, false);
#line 55 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2795, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2821, 83, false);
#line 56 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2904, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(3018, 104, false);
#line 61 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
               Write(Html.LabelFor(model => model.PictureFileName, htmlAttributes: new { @class = "control-label col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(3122, 68, true);
            WriteLiteral("\n                    <div class=\"col-md-8\">\n                        ");
            EndContext();
            BeginContext(3191, 163, false);
#line 63 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.EditorFor(model => model.PictureFileName, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly", Title = "Not allowed for edition" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3354, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(3380, 93, false);
#line 64 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.PictureFileName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3473, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(3587, 103, false);
#line 69 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
               Write(Html.LabelFor(model => model.AvailableStock, htmlAttributes: new { @class = "control-label col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(3690, 68, true);
            WriteLiteral("\n                    <div class=\"col-md-8\">\n                        ");
            EndContext();
            BeginContext(3759, 103, false);
#line 71 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.EditorFor(model => model.AvailableStock, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3862, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(3888, 92, false);
#line 72 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.AvailableStock, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3980, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(4094, 105, false);
#line 77 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
               Write(Html.LabelFor(model => model.RestockThreshold, htmlAttributes: new { @class = "control-label col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(4199, 68, true);
            WriteLiteral("\n                    <div class=\"col-md-8\">\n                        ");
            EndContext();
            BeginContext(4268, 105, false);
#line 79 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.EditorFor(model => model.RestockThreshold, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4373, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(4399, 94, false);
#line 80 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.RestockThreshold, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4493, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(4607, 106, false);
#line 85 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
               Write(Html.LabelFor(model => model.MaxStockThreshold, htmlAttributes: new { @class = "control-label col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(4713, 68, true);
            WriteLiteral("\n                    <div class=\"col-md-8\">\n                        ");
            EndContext();
            BeginContext(4782, 106, false);
#line 87 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.EditorFor(model => model.MaxStockThreshold, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4888, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(4914, 95, false);
#line 88 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.MaxStockThreshold, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5009, 191, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    <div class=\"col-md-12 text-right esh-button-actions\">\n                        ");
            EndContext();
            BeginContext(5201, 100, false);
#line 94 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
                   Write(Html.ActionLink("[ Cancel ]", "Index", null, new { @class = "btn esh-button esh-button-secondary" }));

#line default
#line hidden
            EndContext();
            BeginContext(5301, 202, true);
            WriteLiteral("\n                        <button type=\"submit\" class=\"btn esh-button esh-button-primary\">[ Save ]</button>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 101 "C:\DEV\K8S\Net6Migration\step1-Net6Ported\Views\Catalog\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(5505, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5524, 246, true);
                WriteLiteral("\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.17.0/jquery.validate.min.js\" integrity=\"sha512-O/nUTF5mdFkhEoQHFn9N5wmgYyW323JO6v8kr6ltSRKriZyTr/8417taVWeabVS4iONGk2V444QD0P2cwhuTkg==\" crossorigin=\"anonymous\"></script>\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eShopPorted.Models.CatalogItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
