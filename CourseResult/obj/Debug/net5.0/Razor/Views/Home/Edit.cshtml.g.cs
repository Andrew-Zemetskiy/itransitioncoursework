#pragma checksum "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af62916e7b4fe175df72ac6957ac08d021be030d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af62916e7b4fe175df72ac6957ac08d021be030d", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d026337e1e64c700fdfd297c901dd8407e8199d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseResult.Models.Overview>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
  
	ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Редактирование обзора ");
#nullable restore
#line 6 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 7 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
 using (Html.BeginForm("Edit", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<fieldset>\r\n\t");
#nullable restore
#line 10 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
Write(Html.HiddenFor(p => p.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<p>\r\n\t\t");
#nullable restore
#line 12 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(p => p.Category, "Категория"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n\t\t");
#nullable restore
#line 13 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
   Write(Html.EditorFor(p => p.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</p>\r\n\t<p>\r\n\t\t");
#nullable restore
#line 16 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(p => p.Title, "Заголовок"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n\t\t");
#nullable restore
#line 17 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
   Write(Html.EditorFor(p => p.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</p>\r\n\t<p>\r\n\t\t");
#nullable restore
#line 20 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(p => p.Content, "Содержание"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n\t\t");
#nullable restore
#line 21 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
   Write(Html.EditorFor(p => p.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</p>\r\n\t<p>\r\n\t\t");
#nullable restore
#line 24 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(p => p.Creator, "Создатель"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n\t\t");
#nullable restore
#line 25 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
   Write(Html.EditorFor(p => p.Creator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</p>\r\n\t<p>\r\n\t\t");
#nullable restore
#line 28 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(p => p.Grade, "Оценка"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n\t\t");
#nullable restore
#line 29 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
   Write(Html.EditorFor(p => p.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</p>\r\n\t<p>\r\n\t\t<input type=\"submit\" value=\"Отправить\" />\r\n\t</p>\r\n</fieldset>\r\n");
#nullable restore
#line 35 "D:\Node\Coursework\CourseworkItransition\CourseResult\CourseResult\Views\Home\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseResult.Models.Overview> Html { get; private set; }
    }
}
#pragma warning restore 1591
