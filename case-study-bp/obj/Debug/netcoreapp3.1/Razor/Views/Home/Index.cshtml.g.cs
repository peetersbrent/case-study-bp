#pragma checksum "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c72320a4badc526b7407cf4192cf46eb94c6722"
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
#nullable restore
#line 1 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\_ViewImports.cshtml"
using case_study_bp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\_ViewImports.cshtml"
using case_study_bp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
using Contentful.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c72320a4badc526b7407cf4192cf46eb94c6722", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e219bc840b056b7dba4e5eac73d15dd9ddbc4100", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentfulCollection<VoetbalWedstrijd>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Wedstrijden";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Wedstrijden</h1>\r\n<div class=\"cards\">\r\n");
#nullable restore
#line 11 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
     foreach (var wedstrijd in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 266, "\"", 321, 1);
#nullable restore
#line 15 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
WriteAttributeValue("", 272, wedstrijd.speelveldFoto["fields"]["file"]["url"], 272, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <h1>");
#nullable restore
#line 16 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
           Write(wedstrijd.matchbeschrijving);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h3 class=\"start\">");
#nullable restore
#line 17 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                         Write(wedstrijd.starttijdwedstrijd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3 class=\"wedstrijd\">");
#nullable restore
#line 18 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                             Write(wedstrijd.Thuisploeg);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                                                     Write(wedstrijd.Uitploeg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3 class=\"assistenten\">");
#nullable restore
#line 19 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                               Write(wedstrijd.Assistenten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <button type=\"button\" class=\"btn btnn\" data-bs-toggle=\"modal\" data-bs-target=\"#");
#nullable restore
#line 20 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                                                                                      Write(wedstrijd.wedstrijdnummers);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                Meer wedstrijdinformatie\r\n            </button>\r\n\r\n            <!-- Modal -->\r\n            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 845, "\"", 877, 1);
#nullable restore
#line 25 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
WriteAttributeValue("", 850, wedstrijd.wedstrijdnummers, 850, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 892, "\"", 929, 1);
#nullable restore
#line 25 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
WriteAttributeValue("", 910, wedstrijd.Uitploeg, 910, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\">\r\n                <div class=\"modal-dialog\">\r\n                    <div class=\"modal-content\">\r\n                        <div class=\"modal-header\">\r\n                            <h5 class=\"modal-title\"");
            BeginWriteAttribute("id", " id=\"", 1148, "\"", 1172, 1);
#nullable restore
#line 29 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1153, wedstrijd.Uitploeg, 1153, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Meer info over ");
#nullable restore
#line 29 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                                                                                       Write(wedstrijd.matchbeschrijving);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h5>\r\n                            <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\"><i class=\"bi bi-x-lg\"></i></button>\r\n                        </div>\r\n                        <div class=\"modal-body\">\r\n                            <h3>");
#nullable restore
#line 33 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                           Write(wedstrijd.Thuisploeg);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 33 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                                                   Write(wedstrijd.Uitploeg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"truitjes\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1606, "\"", 1665, 1);
#nullable restore
#line 35 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1612, wedstrijd.Truitjethuisploeg["fields"]["file"]["url"], 1612, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"truitje\" />\r\n                                <p> VS </p>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1768, "\"", 1825, 1);
#nullable restore
#line 37 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1774, wedstrijd.Truitjeuitploeg["fields"]["file"]["url"], 1774, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"truitje\" />\r\n                            </div>\r\n                            <div class=\"stand\">\r\n                                <h3>");
#nullable restore
#line 40 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                               Write(wedstrijd.Standthuisploeg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <h3>");
#nullable restore
#line 41 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                               Write(wedstrijd.Standuitploeg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            </div>\r\n                            <h3>Route</h3>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2180, "\"", 2227, 1);
#nullable restore
#line 44 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2186, wedstrijd.route["fields"]["file"]["url"], 2186, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"route\" />\r\n\r\n                            <div class=\"text-center pt-5\">\r\n                                <h3>Assistenten</h3>\r\n");
#nullable restore
#line 48 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                                 if (wedstrijd.Blokken1 != 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>\r\n                                        Assistent 1 heeft ");
#nullable restore
#line 51 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                                                     Write(wedstrijd.Blokken1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" blokken\r\n                                        <br> Assistent 2 heeft ");
#nullable restore
#line 52 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                                                          Write(wedstrijd.Blokken2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" blokken\r\n                                    </p>\r\n");
#nullable restore
#line 54 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>\r\n                                        Er zijn geen assistenten aangeduid\r\n                                    </p>\r\n");
#nullable restore
#line 60 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <br>\r\n        </div>\r\n");
#nullable restore
#line 70 "C:\Users\peete\OneDrive\School\2de\DevOps\case-study-bp\case-study-bp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentfulCollection<VoetbalWedstrijd>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
