#pragma checksum "C:\Users\Crob01\Documents\GitHub\EscuelaPrograII\Escuela\Escuela\Views\Course\DataCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b09945f45eedc28b56b5189d6c02b562133020a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_DataCourses), @"mvc.1.0.view", @"/Views/Course/DataCourses.cshtml")]
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
#line 1 "C:\Users\Crob01\Documents\GitHub\EscuelaPrograII\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Crob01\Documents\GitHub\EscuelaPrograII\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b09945f45eedc28b56b5189d6c02b562133020a", @"/Views/Course/DataCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad1daf75ad34d7efa7ede8e232fbd89a93ea7bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_DataCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Crob01\Documents\GitHub\EscuelaPrograII\Escuela\Escuela\Views\Course\DataCourses.cshtml"
  
    ViewData["Title"] = "DataCourse";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Course Data</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Crob01\Documents\GitHub\EscuelaPrograII\Escuela\Escuela\Views\Course\DataCourses.cshtml"
 using (Html.BeginForm("Succes", "Course", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <label for=\"Title\">Course Title</label>\r\n    <br>\r\n    <input type=\"text\" name=\"Title\"");
            BeginWriteAttribute("value", " value=\"", 298, "\"", 321, 1);
#nullable restore
#line 14 "C:\Users\Crob01\Documents\GitHub\EscuelaPrograII\Escuela\Escuela\Views\Course\DataCourses.cshtml"
WriteAttributeValue("", 306, ViewBag.titulo, 306, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required>\r\n    <br>\r\n    <label for=\"Credits\"> Credits </label>\r\n    <br>\r\n    <input type=\"number\" name=\"Credits\"");
            BeginWriteAttribute("value", " value=\"", 437, "\"", 460, 1);
#nullable restore
#line 18 "C:\Users\Crob01\Documents\GitHub\EscuelaPrograII\Escuela\Escuela\Views\Course\DataCourses.cshtml"
WriteAttributeValue("", 445, ViewBag.credit, 445, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required>\r\n    <br>\r\n");
            WriteLiteral("    <input type=\"hidden\" name=\"CouserId\"");
            BeginWriteAttribute("value", " value=\"", 577, "\"", 596, 1);
#nullable restore
#line 22 "C:\Users\Crob01\Documents\GitHub\EscuelaPrograII\Escuela\Escuela\Views\Course\DataCourses.cshtml"
WriteAttributeValue("", 585, ViewBag.id, 585, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br>\r\n    <br />\r\n    <input type=\"submit\" class=\"btn btn-success\" value=\"SAVE\" />\r\n");
#nullable restore
#line 26 "C:\Users\Crob01\Documents\GitHub\EscuelaPrograII\Escuela\Escuela\Views\Course\DataCourses.cshtml"


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
