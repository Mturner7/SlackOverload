#pragma checksum "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "765b056cae1b52fcb916b400993592afbf9e0fcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Question), @"mvc.1.0.view", @"/Views/Questions/Question.cshtml")]
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
#line 1 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\_ViewImports.cshtml"
using SlackOverload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\_ViewImports.cshtml"
using SlackOverload.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"765b056cae1b52fcb916b400993592afbf9e0fcb", @"/Views/Questions/Question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc81ec1186c9ee2fd540ead68492bd203ae901", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Question : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Answer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
  
    ViewData["Title"] = ViewData["QuestionTitle"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"page-container\">\r\n    <div class=\"question-container\">\r\n        <div class=\"question-header\">\r\n            <h1 class=\"question-header-title\">");
#nullable restore
#line 10 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
                                         Write(ViewData["QuestionTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <span class=\"question-header-data\">Asked on ");
#nullable restore
#line 11 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
                                                   Write(ViewData["QuestionDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>       \r\n            <span class=\"question-header-data\">Status ");
#nullable restore
#line 12 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
                                                 Write(ViewData["QuestionStatus"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>      \r\n        </div>\r\n        <div class=\"question-description\">\r\n            ");
#nullable restore
#line 15 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
       Write(ViewData["QuestionSummary"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"question-tags\">\r\n            Tags: ");
#nullable restore
#line 18 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
             Write(ViewData["QuestionTags"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
         if (SlackData.CurrentUser == "admin" || SlackData.CurrentUser == (string)ViewData["QuestionUser"])
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"options\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 864, "\"", 923, 2);
            WriteAttributeValue("", 871, "/questions/deletequestion?id=", 871, 29, true);
#nullable restore
#line 23 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
WriteAttributeValue("", 900, ViewData["QuestionId"], 900, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 982, "\"", 1039, 2);
            WriteAttributeValue("", 989, "/questions/editquestion?id=", 989, 27, true);
#nullable restore
#line 24 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
WriteAttributeValue("", 1016, ViewData["QuestionId"], 1016, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
#nullable restore
#line 29 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
     foreach (Answer ans in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"answer-container\"");
            BeginWriteAttribute("id", " id=\"", 1208, "\"", 1226, 1);
#nullable restore
#line 31 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
WriteAttributeValue("", 1213, ans.answerId, 1213, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"answer-header\">\r\n                <span>User: ");
#nullable restore
#line 33 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
                       Write(ans.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span>Posted: ");
#nullable restore
#line 34 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
                         Write(ans.posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"answer-description\">\r\n                <p>");
#nullable restore
#line 37 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
              Write(ans.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 39 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
             if (SlackData.CurrentUser == "admin" || SlackData.CurrentUser == ans.username)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1632, "\"", 1677, 2);
            WriteAttributeValue("", 1639, "/questions/editanswer?id=", 1639, 25, true);
#nullable restore
#line 41 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
WriteAttributeValue("", 1664, ans.answerId, 1664, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1735, "\"", 1782, 2);
            WriteAttributeValue("", 1742, "/questions/deleteanswer?id=", 1742, 27, true);
#nullable restore
#line 42 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
WriteAttributeValue("", 1769, ans.answerId, 1769, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n");
#nullable restore
#line 43 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 45 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n");
#nullable restore
#line 47 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
     if (Model.Count < 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>No responses yet!</div>\r\n");
#nullable restore
#line 50 "C:\Users\mturner7\dev\week5labs\SlackOverload\SlackOverload\Views\Questions\Question.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Answer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
