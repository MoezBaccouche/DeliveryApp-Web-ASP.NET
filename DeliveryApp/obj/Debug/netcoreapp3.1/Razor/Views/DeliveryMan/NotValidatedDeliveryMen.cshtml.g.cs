#pragma checksum "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b339f670d0987a2550c7c2fa9db1341de5a9d513"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeliveryMan_NotValidatedDeliveryMen), @"mvc.1.0.view", @"/Views/DeliveryMan/NotValidatedDeliveryMen.cshtml")]
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
#line 1 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\_ViewImports.cshtml"
using DeliveryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\_ViewImports.cshtml"
using DeliveryApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\_ViewImports.cshtml"
using DeliveryApp.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b339f670d0987a2550c7c2fa9db1341de5a9d513", @"/Views/DeliveryMan/NotValidatedDeliveryMen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b039239c523156bb20d4f0ce2e0343c1f090be35", @"/Views/_ViewImports.cshtml")]
    public class Views_DeliveryMan_NotValidatedDeliveryMen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeliveryApp.Models.ViewModels.DeliveryMenViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
  
    ViewData["Title"] = "NotValidatedDeliveryMan";
    ViewBag.CurrentController = "DeliveryMan";
    ViewBag.CurrentAction = "ValidateDeliveryMan";
    ViewBag.CurrentViewTitle = "Livreurs non validés";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
 if (TempData["Message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-success alert-dismissible fade show"">
        <button type=""button"" aria-hidden=""true"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <i class=""nc-icon nc-simple-remove""></i>
        </button>
        <span>");
#nullable restore
#line 16 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
         Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Livreurs non validés</h1>

<div class=""row"">

    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <strong class=""card-title"">Data Table</strong>
            </div>
            <div class=""card-body"">
                <table id=""bootstrap-data-table-export"" class=""table table-striped table-bordered"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Prénom</th>
                            <th>Nom</th>
                            <th>Adresse</th>
                            <th>Email</th>
                            <th>Téléphone</th>
                            <th>Opération</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 43 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
                         foreach (var man in Model.NotValidatedDeliveryMen)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
                               Write(man.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
                               Write(man.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
                               Write(man.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
                               Write(man.Location.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 50 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
                               Write(man.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 51 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
                               Write(man.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2019, "\"", 2054, 2);
            WriteAttributeValue("", 2026, "AcceptDeliveryMan?id=", 2026, 21, true);
#nullable restore
#line 53 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
WriteAttributeValue("", 2047, man.Id, 2047, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i style=\"font-size: 20px;\" class=\"fa fa-check text-info \"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2163, "\"", 2198, 2);
            WriteAttributeValue("", 2170, "RejectDeliveryMan?id=", 2170, 21, true);
#nullable restore
#line 54 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
WriteAttributeValue("", 2191, man.Id, 2191, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i style=\"font-size: 20px; margin-left: 10px\" class=\"fa fa-close text-danger\"></i></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\NotValidatedDeliveryMen.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliveryApp.Models.ViewModels.DeliveryMenViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
