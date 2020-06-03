#pragma checksum "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b47658699572abe448bcddc9691790e9760c3f9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeliveryMan_AllDeliveryMen), @"mvc.1.0.view", @"/Views/DeliveryMan/AllDeliveryMen.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b47658699572abe448bcddc9691790e9760c3f9e", @"/Views/DeliveryMan/AllDeliveryMen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b039239c523156bb20d4f0ce2e0343c1f090be35", @"/Views/_ViewImports.cshtml")]
    public class Views_DeliveryMan_AllDeliveryMen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeliveryApp.Models.ViewModels.DeliveryMenViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/bootbox.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
  
    ViewData["Title"] = "AllDeliveryMen";
    ViewBag.CurrentController = "DeliveryMan";
    ViewBag.CurrentAction = "AllDeliveryMen";
    ViewBag.CurrentViewTitle = "Liste des livreurs";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
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
#line 15 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
         Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""divDeleteSuccess"" style=""display: none"" class=""alert alert-success alert-dismissible fade show"">
    <button type=""button"" aria-hidden=""true"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
        <i class=""nc-icon nc-simple-remove""></i>
    </button>
    <span>Livreur supprimé !</span>
</div>

<h1>Liste des livreurs</h1>

<div class=""container-fluid"">
    <div class=""row"">
");
#nullable restore
#line 30 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
         foreach (var man in Model.AllDeliveryMen)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-4 col-sm-4 col-lg-4"">
                <div class=""card deliveryMan-card"" style=""width: 18rem;"">
                    <div class=""text-center deliveryMan-card-header mt-3"">
                        <img height=""100"" width=""100""");
            BeginWriteAttribute("src", " src=\"", 1329, "\"", 1364, 1);
#nullable restore
#line 35 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
WriteAttributeValue("", 1335, Url.Content(man.PicturePath), 1335, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img rounded-circle img-deliveryMan-card\" alt=\"Image\">\r\n                    </div>\r\n\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title text-center\">");
#nullable restore
#line 39 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
                                                      Write(man.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
                                                                     Write(man.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\"><strong>Email:</strong> ");
#nullable restore
#line 40 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
                                                                Write(man.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"><strong>Téléphone:</strong> ");
#nullable restore
#line 41 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
                                                                    Write(man.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        <div class=\"float-right\">\r\n                            <a href=\"#\" class=\"btn btn-simple btn-info btn-icon ajaxBtn\" data-link=\"/DeliveryMan/EditDeliveryMan?id=");
#nullable restore
#line 44 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
                                                                                                                               Write(man.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-title=\"Modifier Livreur\"><i class=\"fa fa-pencil\" title=\"Modifier\"></i></a>\r\n                            <a id=\"btDelete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2090, "\"", 2126, 3);
            WriteAttributeValue("", 2100, "deleteDeliveryMan(", 2100, 18, true);
#nullable restore
#line 45 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
WriteAttributeValue("", 2118, man.Id, 2118, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2125, ")", 2125, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-simple btn-danger btn-icon\"><i class=\"fa fa-trash\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 50 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b47658699572abe448bcddc9691790e9760c3f9e9738", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>

        function deleteDeliveryMan(idDeliveryMan) {
            debugger;
            bootbox.confirm({
                title: ""Confirmation suppression"",
                message: ""Etes-vous certain de vouloir supprimer ce livreur ?"",
                buttons: {
                    cancel: {
                        label: '<i class=""fa fa-times""></i> Annuler'
                    },
                    confirm: {
                        label: '<i class=""fa fa-check""></i> Confirmer'
                    }
                },
                callback: function (result) {
                    if (result) {
                            $.ajax({
                                url: '");
#nullable restore
#line 74 "C:\Users\Moez\source\repos\DeliveryApp\DeliveryApp\Views\DeliveryMan\AllDeliveryMen.cshtml"
                                 Write(Url.Action("DeleteDeliveryMan", "DeliveryMan"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                                data: { id: idDeliveryMan },
                                type: 'GET',
                                dataType: 'html',
                                success: function () {
                                    window.location.reload();
                            }
                        });

                    }
                }
            });
        }

        function deliveryManPicChanged(e) {
            console.log(e);
            var files = $(""#file"")[0].files;
            console.log(files);
            getBase64(files[0]).then(
                 data => setDeliveryManPic(data)
            );
            
        }

        function setDeliveryManPic(str) {
            $(""#deliveryManPic"").attr(""src"", str);
        }

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliveryApp.Models.ViewModels.DeliveryMenViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
