#pragma checksum "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Music.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e139b00f66849382caf88fd7aee6e43254072cf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Music), @"mvc.1.0.view", @"/Views/Home/Music.cshtml")]
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
#line 1 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\_ViewImports.cshtml"
using CourseResult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\_ViewImports.cshtml"
using CourseResult.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e139b00f66849382caf88fd7aee6e43254072cf7", @"/Views/Home/Music.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d026337e1e64c700fdfd297c901dd8407e8199d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Music : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseResult.Models.Overview>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Music.cshtml"
  
	ViewData["Title"] = "Music";
	Layout = "CustomLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n\t<br>\r\n\t<div class=\"form-group\">\r\n\t\t<table class=\"table-bordered\" style=\"font-size:14pt;\" cellpadding=\"8\">\r\n\t\t\t<tr style=\"font-weight: bold; text-decoration:underline;\" class=\"font-italic\"><td>Обзор</td><td>Автор</td><td>Оценка</td></tr>\r\n");
#nullable restore
#line 12 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Music.cshtml"
             foreach (var a in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 15 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Music.cshtml"
                   Write(Html.DisplayFor(modela => a.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 16 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Music.cshtml"
                   Write(Html.DisplayFor(modela => a.Creator));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td style=\"text-align:center\">");
#nullable restore
#line 17 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Music.cshtml"
                                             Write(Html.DisplayFor(modela => a.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("/10</td>\r\n\t\t\t\t\t<td style=\"font-weight:400\">");
#nullable restore
#line 18 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Music.cshtml"
                                           Write(Html.ActionLink("Читать", "Viewing", new { id = a.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 20 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Music.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</table>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseResult.Models.Overview>> Html { get; private set; }
    }
}
#pragma warning restore 1591
