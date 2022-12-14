#pragma checksum "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\User\DeleteUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d844b711342e81af7fab0fc8580f3be7134fdb45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_DeleteUser), @"mvc.1.0.view", @"/Views/User/DeleteUser.cshtml")]
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
#line 1 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\_ViewImports.cshtml"
using LearnIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\_ViewImports.cshtml"
using LearnIdentity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d844b711342e81af7fab0fc8580f3be7134fdb45", @"/Views/User/DeleteUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d5cfaf9b1ee846420c50396be8770cfa8ef073", @"/Views/_ViewImports.cshtml")]
    public class Views_User_DeleteUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Microsoft.AspNetCore.Identity.IdentityUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\User\DeleteUser.cshtml"
   ViewBag.Title = "All Users";
    Layout = "~/Views/Shared/AdminLTE/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>All Users</h1>\n<table class=\"table table-striped\">\n");
            WriteLiteral("    <tbody>\n");
#nullable restore
#line 15 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\User\DeleteUser.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card mb-3\">\n    <div class=\"card-header\">\n        User ID : ");
#nullable restore
#line 19 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\User\DeleteUser.cshtml"
             Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"card-body\">\n        User ID : ");
#nullable restore
#line 22 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\User\DeleteUser.cshtml"
             Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div> ");
            WriteLiteral("                <div class=\"card-footer\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d844b711342e81af7fab0fc8580f3be7134fdb455161", async() => {
                WriteLiteral("\n                        <button type=\"submit\" class=\"btn btn-danger\"");
                BeginWriteAttribute("onclick", " onclick=\"", 887, "\"", 968, 12);
                WriteAttributeValue("", 897, "return", 897, 6, true);
                WriteAttributeValue(" ", 903, "confirm(\'Are", 904, 13, true);
                WriteAttributeValue(" ", 916, "you", 917, 4, true);
                WriteAttributeValue(" ", 920, "sure", 921, 5, true);
                WriteAttributeValue(" ", 925, "you", 926, 4, true);
                WriteAttributeValue(" ", 929, "want", 930, 5, true);
                WriteAttributeValue(" ", 934, "to", 935, 3, true);
                WriteAttributeValue(" ", 937, "delete", 938, 7, true);
                WriteAttributeValue(" ", 944, "user", 945, 5, true);
                WriteAttributeValue(" ", 949, ":", 950, 2, true);
#nullable restore
#line 31 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\User\DeleteUser.cshtml"
WriteAttributeValue(" ", 951, user.UserName, 952, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 966, "\')", 966, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\n                            Delete\n                        </button>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\User\DeleteUser.cshtml"
                                                                          WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                </div>");
#nullable restore
#line 36 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\User\DeleteUser.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Microsoft.AspNetCore.Identity.IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
