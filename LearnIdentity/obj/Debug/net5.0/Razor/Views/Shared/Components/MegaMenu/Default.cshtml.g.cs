#pragma checksum "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Shared\Components\MegaMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12cb9f6d116b29caf4e0daebcd34a9e88203ecbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MegaMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MegaMenu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12cb9f6d116b29caf4e0daebcd34a9e88203ecbd", @"/Views/Shared/Components/MegaMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d5cfaf9b1ee846420c50396be8770cfa8ef073", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MegaMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LearnIdentity.ViewModels.MenuPermissionMappingViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <li class=\"nav-item\">\r\n        <a href=\"/Home/Index\" class=\"nav-link\">\r\n            <i class=\"fas fa-circle nav-icon\"></i>\r\n            <p>");
#nullable restore
#line 6 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Shared\Components\MegaMenu\Default.cshtml"
          Write(ViewBag.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </a>\r\n    </li>\r\n");
#nullable restore
#line 9 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Shared\Components\MegaMenu\Default.cshtml"
  foreach (var item in Model.GroupBy(m => m.ParentId).ToList())
    {

        foreach (var firstItem in (Model.Where(p => p.ParentId == item.FirstOrDefault().ParentId).ToList()))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Shared\Components\MegaMenu\Default.cshtml"
             if (firstItem.ParentId==0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 582, "\"", 589, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                        <i class=\"fas fa-circle nav-icon\"></i>\r\n                        <p>");
#nullable restore
#line 19 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Shared\Components\MegaMenu\Default.cshtml"
                      Write(firstItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </a>\r\n                    <ul class=\"nav nav-treeview\">\r\n");
#nullable restore
#line 23 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Shared\Components\MegaMenu\Default.cshtml"
                         foreach (var secondItem in (Model.Where(s => s.ParentId == firstItem.Id).ToList()))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1052, "\"", 1059, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                                    <i class=\"far fa-circle nav-icon\"></i>\r\n                                    <p>");
#nullable restore
#line 28 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Shared\Components\MegaMenu\Default.cshtml"
                                  Write(secondItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </a>\r\n\r\n                            </li>\r\n");
#nullable restore
#line 32 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Shared\Components\MegaMenu\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n\r\n                </li>\r\n");
#nullable restore
#line 36 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Shared\Components\MegaMenu\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Shared\Components\MegaMenu\Default.cshtml"
             
        }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LearnIdentity.ViewModels.MenuPermissionMappingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
