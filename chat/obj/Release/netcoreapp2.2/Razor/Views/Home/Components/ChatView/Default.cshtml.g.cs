#pragma checksum "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\Home\Components\ChatView\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8692d539dd6618febcd6ee01f112a4e59efa29a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_ChatView_Default), @"mvc.1.0.view", @"/Views/Home/Components/ChatView/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Components/ChatView/Default.cshtml", typeof(AspNetCore.Views_Home_Components_ChatView_Default))]
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
#line 1 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\_ViewImports.cshtml"
using chat;

#line default
#line hidden
#line 2 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\_ViewImports.cshtml"
using chat.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8692d539dd6618febcd6ee01f112a4e59efa29a3", @"/Views/Home/Components/ChatView/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b6f2a76b132e818a8a34dd9ab382ce4bfcfc10", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_ChatView_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<chat.Models.Chat>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/dust.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\Home\Components\ChatView\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\Home\Components\ChatView\Default.cshtml"
  
    int i = 1;
    foreach (chat.Models.Chat m in Model)
    {


#line default
#line hidden
            BeginContext(141, 167, true);
            WriteLiteral("        <div class=\"panel panel-default\" style=\"margin-top:5px;margin-bottom:5px;\">\r\n            <div class=\"panel-heading\">\r\n                <label class=\"text-left\">");
            EndContext();
            BeginContext(309, 11, false);
#line 14 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\Home\Components\ChatView\Default.cshtml"
                                    Write(m.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(320, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(324, 6, false);
#line 14 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\Home\Components\ChatView\Default.cshtml"
                                                   Write(m.Date);

#line default
#line hidden
            EndContext();
            BeginContext(330, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 15 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\Home\Components\ChatView\Default.cshtml"
                  

                    if (Model.Count() == i)
                    {

#line default
#line hidden
            BeginContext(430, 71, true);
            WriteLiteral("                        <span class=\"label label-primary\">New!</span>\r\n");
            EndContext();
#line 20 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\Home\Components\ChatView\Default.cshtml"
                    }
                    i++;
                

#line default
#line hidden
            BeginContext(569, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\Home\Components\ChatView\Default.cshtml"
                 if (int.Parse(User.FindFirst("UserId").Value) == m.UserId)
                {

#line default
#line hidden
            BeginContext(667, 62, true);
            WriteLiteral("                <div class=\"pull-right\">\r\n                    ");
            EndContext();
            BeginContext(729, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8692d539dd6618febcd6ee01f112a4e59efa29a36876", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\Home\Components\ChatView\Default.cshtml"
AddHtmlAttributeValue("", 739, m.ChatId, 739, 9, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(788, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 29 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\Home\Components\ChatView\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(833, 96, true);
            WriteLiteral("                </div>\r\n                \r\n            <div class=\"panel-body\">\r\n                ");
            EndContext();
            BeginContext(930, 6, false);
#line 33 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\Home\Components\ChatView\Default.cshtml"
           Write(m.Talk);

#line default
#line hidden
            EndContext();
            BeginContext(936, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 36 "C:\Users\umemura\Documents\CSharpProjects\AccessChat_LocalDb\chat\chat\Views\Home\Components\ChatView\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(984, 162, true);
            WriteLiteral("\r\n<script>\r\n\r\n    //削除\r\n    //送信ボタン\r\n    $(\'img\').click(function () {\r\n        var id = $(this).attr(\"alt\");\r\n        $.get(\'/api/Chat/\'+id);\r\n    })\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<chat.Models.Chat>> Html { get; private set; }
    }
}
#pragma warning restore 1591
