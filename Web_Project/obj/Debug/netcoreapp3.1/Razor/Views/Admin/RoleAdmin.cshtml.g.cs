#pragma checksum "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16abb1cb59e41182b3c51c8408334a61661fc901"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleAdmin), @"mvc.1.0.view", @"/Views/Admin/RoleAdmin.cshtml")]
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
#line 1 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\_ViewImports.cshtml"
using Web_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\_ViewImports.cshtml"
using Web_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
using Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16abb1cb59e41182b3c51c8408334a61661fc901", @"/Views/Admin/RoleAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d116a1c33850dd3363f313778efdc9aba3d29081", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RoleAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/Admin/Table.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Sidebar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
   ViewData["Title"] = localizer["PageTitle"]; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "16abb1cb59e41182b3c51c8408334a61661fc9016148", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 6 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n<div id=\"wrapper\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "16abb1cb59e41182b3c51c8408334a61661fc9018120", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <div class=\"container project-list-margin\">\n");
#nullable restore
#line 12 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
         if (TempData["ErrorMessage"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\">\n        <strong>");
#nullable restore
#line 15 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
           Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n    </div>");
#nullable restore
#line 16 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
         if (TempData["SuccessMessage"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\n        <strong>");
#nullable restore
#line 20 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
           Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n    </div>");
#nullable restore
#line 21 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"table-responsive\">\n            <table class=\"table colored-header datatable project-list\">\n                <thead>\n                    <tr>\n                        <th>");
#nullable restore
#line 26 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
                       Write(localizer["UserName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th>");
#nullable restore
#line 27 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
                       Write(localizer["UserMail"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th>");
#nullable restore
#line 28 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
                       Write(localizer["UserRegisterDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th>");
#nullable restore
#line 29 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
                       Write(localizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 33 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
                     foreach (var User in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1251, "\"", 1283, 2);
            WriteAttributeValue("", 1258, "/Account/Profile/", 1258, 17, true);
#nullable restore
#line 36 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
WriteAttributeValue("", 1275, User.Id, 1275, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
                                               Write(User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1323, "\"", 1355, 2);
            WriteAttributeValue("", 1330, "/Account/Profile/", 1330, 17, true);
#nullable restore
#line 37 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
WriteAttributeValue("", 1347, User.Id, 1347, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
                                               Write(User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n            <td>");
#nullable restore
#line 38 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
           Write(User.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16abb1cb59e41182b3c51c8408334a61661fc90114200", async() => {
                WriteLiteral("<i class=\"far fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
                                                                                                          WriteLiteral(User.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 44 "C:\Users\burak\Desktop\Web_Project_15\Web_Project\Views\Admin\RoleAdmin.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
