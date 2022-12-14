#pragma checksum "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6427c649040677f328c0c827ad6ccb7e44d14c6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Permission_GetPermissions), @"mvc.1.0.view", @"/Views/Permission/GetPermissions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6427c649040677f328c0c827ad6ccb7e44d14c6a", @"/Views/Permission/GetPermissions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d5cfaf9b1ee846420c50396be8770cfa8ef073", @"/Views/_ViewImports.cshtml")]
    public class Views_Permission_GetPermissions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LearnIdentity.ViewModels.MenuPermissionMappingViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
      
        ViewBag.Title = "Menu Permission";
        Layout = "~/Views/Shared/AdminLTE/_Layout.cshtml";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
     if (Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-12\">\r\n        <div class=\"card\">\r\n\r\n            <div class=\"card-header\">\r\n                <label>Select Role</label><br />\r\n                ");
#nullable restore
#line 13 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
           Write(Html.DropDownList("RoleId", (IEnumerable<SelectListItem>
                    )ViewBag.RolesList, "Select"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    <button id=""btnSave"" class=""btn btn-primary fa-pull-right"">Save</button>
            </div>
            <div class=""card-body p-0"">
                <table id=""idgrid"" class=""table"">
                    <thead>
                        <tr>
                            <th style=""width: 10px"">#</th>
                            <th>Permission Id</th>
                            <th>Name</th>
                            <th>ParentId</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 30 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
                         foreach (var menu in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><input type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 1226, "\"", 1242, 1);
#nullable restore
#line 33 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
WriteAttributeValue("", 1234, menu.Id, 1234, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 1243, "\"", 1268, 1);
#nullable restore
#line 33 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
WriteAttributeValue("", 1253, menu.HasAccess, 1253, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                            <td>");
#nullable restore
#line 34 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
                           Write(menu.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
                           Write(menu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
                           Write(menu.ParentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 38 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 46 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            No menu created yet\r\n        </div>\r\n");
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 65 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js"" crossorigin=""anonymous""></script>
    <script type=""text/javascript"">

        $(document).ready(function () {
            $(""#RoleId"").on(""change"", function () {
                var selectedId = $(this).val();
                window.location.href = '");
#nullable restore
#line 73 "F:\BhanuProject\LearnIdentity\LearnIdentity\Views\Permission\GetPermissions.cshtml"
                                   Write(Url.Action("GetPermissions", "Permission"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?RoleId=' + selectedId;
            });
            $(""#btnSave"").on('click', function (e) {
                var RoleId = $('#RoleId').val();
                var arr = [];
                $('#idgrid').find('input[type=""checkbox""]:checked').each(function () {
                    requestData = {
                        MenuId: this.value,
                        RoleId: RoleId
                    }
                    arr.push(requestData);
                });
                $.ajax({
                    url: '/Permission/UpdatePermission',
                    type: 'POST',
                    data: JSON.stringify(arr),
                    dataType: 'json',
                    contentType: 'application/json',
                    error: function (xhr) {
                        alert('Error: ' + xhr.statusText);
                    },
                    success: function (result) {
                        alert(result);
                    },

                });

            });");
            WriteLiteral("\n        });\r\n    </script>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/v/dt/dt-1.10.25/af-2.3.7/datatables.min.css"" />

    <script type=""text/javascript"" src=""https://cdn.datatables.net/v/dt/dt-1.10.25/af-2.3.7/datatables.min.js""></script>

    <script>
        $(document).ready(function () {
            $(""#MyDataTable"").DataTable();
        }
        )
    </script>
    ");
            }
            );
            WriteLiteral("\r\n");
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
