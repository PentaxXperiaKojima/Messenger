#pragma checksum "C:\Users\umemura\Documents\CSharpProjects\AccessChat\chat\chat\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "517645ccf1a063f85e8f52c8508ab910a5d84b0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\umemura\Documents\CSharpProjects\AccessChat\chat\chat\Views\_ViewImports.cshtml"
using chat;

#line default
#line hidden
#line 2 "C:\Users\umemura\Documents\CSharpProjects\AccessChat\chat\chat\Views\_ViewImports.cshtml"
using chat.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"517645ccf1a063f85e8f52c8508ab910a5d84b0c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b6f2a76b132e818a8a34dd9ab382ce4bfcfc10", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chat>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\umemura\Documents\CSharpProjects\AccessChat\chat\chat\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(60, 578, true);
            WriteLiteral(@"

<style>

    .scroll {
        overflow-y: auto;
    }

    .height-fixed {
        height: 95vh;
    }
</style>



        <!-- right -->
        <div class=""col-sm-9"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    ログ
                    <div class=""pull-right"">
                        <input type=""checkbox"" id=""check"">
                    </div>
                </div>
                <div id=""update1"" class=""panel-body"" style=""height:500px;overflow:auto;"">


                    ");
            EndContext();
            BeginContext(639, 39, false);
#line 33 "C:\Users\umemura\Documents\CSharpProjects\AccessChat\chat\chat\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("ChatView"));

#line default
#line hidden
            EndContext();
            BeginContext(678, 161, true);
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"panel panel-default\">\r\n\r\n                <div class=\"panel-body\">\r\n                    ");
            EndContext();
            BeginContext(839, 547, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "517645ccf1a063f85e8f52c8508ab910a5d84b0c5099", async() => {
                BeginContext(869, 510, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label"" for=""InputText"">発言内容</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" class=""form-control"" id=""InputText"" placeholder=""発言"">
                            </div>
                        </div>
                        <button id=""btn"" type=""button"" class=""btn btn-info col-lg-offset-10 col-sm-2"">発信</button>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1386, 1435, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>


<script>

    //読み込み時
    $(document).ready(function () {

        if (""Notification"" in window) {
            var permission = Notification.permission;

            if (permission === ""denied"" || permission === ""granted"") {
                return;
            }

            Notification.requestPermission();
        }
    });

    //送信ボタン
    $('#btn').click(function () {
        $.ajax({
            url: '/api/Chat/',
            type: 'POST',
            contentType: 'application/json', // リクエストの Content-Type
            data: JSON.stringify({
                'Id': 0,
                'Talk': $('#InputText').val(),
                'Date': ""2000-01-01 00:00:00""
            }),

        });
    })

    //更新
    var container = $(""#update1"");
    var refreshComponent = function () {
        $.get(""/Home/ChatView/1"", function (data) {
            var unko = container.html();
            if (countStr(unko, ""div"")");
            WriteLiteral(@" != countStr(data, ""div"")) {
                container.html(data);
                var n = new Notification(""New Message !!"");
                $(""#update1"").scrollTop($(""#update1"")[0].scrollHeight);

            }
        });
    };

    $(function () { window.setInterval(refreshComponent, 500); });


    function countStr(str, seq) {
        return str.split(seq).length - 1;
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chat> Html { get; private set; }
    }
}
#pragma warning restore 1591
