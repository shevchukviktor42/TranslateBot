#pragma checksum "C:\Users\User\Desktop\dev\TranslateBot\TranslateBot\Views\Phrases\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d7fd248f86f79c47fe90e6f4d9e1ca483d19df9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phrases_Edit), @"mvc.1.0.view", @"/Views/Phrases/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Phrases/Edit.cshtml", typeof(AspNetCore.Views_Phrases_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d7fd248f86f79c47fe90e6f4d9e1ca483d19df9", @"/Views/Phrases/Edit.cshtml")]
    public class Views_Phrases_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TranslateBot.Models.Phrase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\dev\TranslateBot\TranslateBot\Views\Phrases\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\User\Desktop\dev\TranslateBot\TranslateBot\Views\Phrases\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(101, 23, false);
#line 9 "C:\Users\User\Desktop\dev\TranslateBot\TranslateBot\Views\Phrases\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(128, 82, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Edit</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(211, 64, false);
#line 14 "C:\Users\User\Desktop\dev\TranslateBot\TranslateBot\Views\Phrases\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(275, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(286, 39, false);
#line 15 "C:\Users\User\Desktop\dev\TranslateBot\TranslateBot\Views\Phrases\Edit.cshtml"
   Write(Html.HiddenFor(model => model.PhraseId));

#line default
#line hidden
            EndContext();
            BeginContext(325, 103, true);
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n          \r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(429, 92, false);
#line 20 "C:\Users\User\Desktop\dev\TranslateBot\TranslateBot\Views\Phrases\Edit.cshtml"
           Write(Html.EditorFor(model => model.src, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(521, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(540, 81, false);
#line 21 "C:\Users\User\Desktop\dev\TranslateBot\TranslateBot\Views\Phrases\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.src, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(621, 138, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n         \r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(760, 92, false);
#line 28 "C:\Users\User\Desktop\dev\TranslateBot\TranslateBot\Views\Phrases\Edit.cshtml"
           Write(Html.EditorFor(model => model.dst, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(852, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(871, 81, false);
#line 29 "C:\Users\User\Desktop\dev\TranslateBot\TranslateBot\Views\Phrases\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.dst, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(952, 253, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 39 "C:\Users\User\Desktop\dev\TranslateBot\TranslateBot\Views\Phrases\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(1208, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1222, 40, false);
#line 42 "C:\Users\User\Desktop\dev\TranslateBot\TranslateBot\Views\Phrases\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1262, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TranslateBot.Models.Phrase> Html { get; private set; }
    }
}
#pragma warning restore 1591