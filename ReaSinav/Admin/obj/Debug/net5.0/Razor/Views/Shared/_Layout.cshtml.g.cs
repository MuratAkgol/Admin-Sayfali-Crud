#pragma checksum "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8d3bb7edeb2cecf2339d6adee661fab80b066f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d3bb7edeb2cecf2339d6adee661fab80b066f6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form d-flex align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Task", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8d3bb7edeb2cecf2339d6adee661fab80b066f66602", async() => {
                WriteLiteral(@"
    <style>
        #ust {
            margin-top: 10%;
        }
    </style>
    <meta charset=""utf-8"">
    <meta content=""width=device-width, initial-scale=1.0"" name=""viewport"">

    <title>Dashboard - NiceAdmin Bootstrap Template</title>
    <meta");
                BeginWriteAttribute("content", " content=\"", 305, "\"", 315, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"description\">\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 347, "\"", 357, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""keywords"">

    <!-- Favicons -->
    <link href=""/img/favicon.png"" rel=""icon"">
    <link href=""/img/apple-touch-icon.png"" rel=""apple-touch-icon"">

    <!-- Google Fonts -->
    <link href=""https://fonts.gstatic.com"" rel=""preconnect"">
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Nunito:300,300i,400,400i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i"" rel=""stylesheet"">

    <!-- Vendor CSS Files -->
    <link href=""/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""/vendor/bootstrap-icons/bootstrap-icons.css"" rel=""stylesheet"">
    <link href=""/vendor/boxicons/css/boxicons.min.css"" rel=""stylesheet"">
    <link href=""/vendor/quill/quill.snow.css"" rel=""stylesheet"">
    <link href=""/vendor/quill/quill.bubble.css"" rel=""stylesheet"">
    <link href=""/vendor/remixicon/remixicon.css"" rel=""stylesheet"">
    <link href=""/vendor/simple-datatables/style.css"" rel=""stylesheet"">

    <!-- Template M");
                WriteLiteral(@"ain CSS File -->
    <link href=""/css/style.css"" rel=""stylesheet"">

    <!-- =======================================================
    * Template Name: NiceAdmin - v2.4.1
    * Template URL: https://bootstrapmade.com/nice-admin-bootstrap-admin-html-template/
    * Author: BootstrapMade.com
    * License: https://bootstrapmade.com/license/
    ======================================================== -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8d3bb7edeb2cecf2339d6adee661fab80b066f69712", async() => {
                WriteLiteral(@"

    <!-- ======= Header ======= -->
    <header id=""header"" class=""header fixed-top d-flex align-items-center"">

        <div class=""d-flex align-items-center justify-content-between"">
            <a href=""index.html"" class=""logo d-flex align-items-center"">
                <img src=""/img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 2123, "\"", 2129, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <span class=\"d-none d-lg-block\">NiceAdmin</span>\r\n            </a>\r\n            <i class=\"bi bi-list toggle-sidebar-btn\"></i>\r\n        </div><!-- End Logo -->\r\n\r\n        <div class=\"search-bar\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8d3bb7edeb2cecf2339d6adee661fab80b066f610683", async() => {
                    WriteLiteral("\r\n                <input type=\"text\" name=\"query\" placeholder=\"Search\" title=\"Enter search keyword\">\r\n                <button type=\"submit\" title=\"Search\"><i class=\"bi bi-search\"></i></button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div><!-- End Search Bar -->\r\n\r\n        <div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8d3bb7edeb2cecf2339d6adee661fab80b066f612657", async() => {
                    WriteLiteral("Görev Ekle");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>

        <nav class=""header-nav ms-auto"">
            <ul class=""d-flex align-items-center"">

                <li class=""nav-item d-block d-lg-none"">
                    <a class=""nav-link nav-icon search-bar-toggle "" href=""#"">
                        <i class=""bi bi-search""></i>
                    </a>
                </li><!-- End Search Icon-->

                <li class=""nav-item dropdown"">

                    <a class=""nav-link nav-icon"" href=""#"" data-bs-toggle=""dropdown"">
                        <i class=""bi bi-bell""></i>
                        <span class=""badge bg-primary badge-number"">4</span>
                    </a><!-- End Notification Icon -->

                    <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow notifications"">
                        <li class=""dropdown-header"">
                            You have 4 new notifications
                            <a href=""#""><span class=""badge rounded-pill bg-primary p-2 ms-2"">View all</span>");
                WriteLiteral(@"</a>
                        </li>
                        <li>
                            <hr class=""dropdown-divider"">
                        </li>

                        <li class=""notification-item"">
                            <i class=""bi bi-exclamation-circle text-warning""></i>
                            <div>
                                <h4>Lorem Ipsum</h4>
                                <p>Quae dolorem earum veritatis oditseno</p>
                                <p>30 min. ago</p>
                            </div>
                        </li>

                        <li>
                            <hr class=""dropdown-divider"">
                        </li>

                        <li class=""notification-item"">
                            <i class=""bi bi-x-circle text-danger""></i>
                            <div>
                                <h4>Atque rerum nesciunt</h4>
                                <p>Quae dolorem earum veritatis oditseno</p>
            ");
                WriteLiteral(@"                    <p>1 hr. ago</p>
                            </div>
                        </li>

                        <li>
                            <hr class=""dropdown-divider"">
                        </li>

                        <li class=""notification-item"">
                            <i class=""bi bi-check-circle text-success""></i>
                            <div>
                                <h4>Sit rerum fuga</h4>
                                <p>Quae dolorem earum veritatis oditseno</p>
                                <p>2 hrs. ago</p>
                            </div>
                        </li>

                        <li>
                            <hr class=""dropdown-divider"">
                        </li>

                        <li class=""notification-item"">
                            <i class=""bi bi-info-circle text-primary""></i>
                            <div>
                                <h4>Dicta reprehenderit</h4>
                     ");
                WriteLiteral(@"           <p>Quae dolorem earum veritatis oditseno</p>
                                <p>4 hrs. ago</p>
                            </div>
                        </li>

                        <li>
                            <hr class=""dropdown-divider"">
                        </li>
                        <li class=""dropdown-footer"">
                            <a href=""#"">Show all notifications</a>
                        </li>

                    </ul><!-- End Notification Dropdown Items -->

                </li><!-- End Notification Nav -->

                <li class=""nav-item dropdown"">

                    <a class=""nav-link nav-icon"" href=""#"" data-bs-toggle=""dropdown"">
                        <i class=""bi bi-chat-left-text""></i>
                        <span class=""badge bg-success badge-number"">3</span>
                    </a><!-- End Messages Icon -->

                    <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow messages"">
                        ");
                WriteLiteral(@"<li class=""dropdown-header"">
                            You have 3 new messages
                            <a href=""#""><span class=""badge rounded-pill bg-primary p-2 ms-2"">View all</span></a>
                        </li>
                        <li>
                            <hr class=""dropdown-divider"">
                        </li>

                        <li class=""message-item"">
                            <a href=""#"">
                                <img src=""/img/messages-1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 7410, "\"", 7416, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""rounded-circle"">
                                <div>
                                    <h4>Maria Hudson</h4>
                                    <p>Velit asperiores et ducimus soluta repudiandae labore officia est ut...</p>
                                    <p>4 hrs. ago</p>
                                </div>
                            </a>
                        </li>
                        <li>
                            <hr class=""dropdown-divider"">
                        </li>

                        <li class=""message-item"">
                            <a href=""#"">
                                <img src=""/img/messages-2.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 8094, "\"", 8100, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""rounded-circle"">
                                <div>
                                    <h4>Anna Nelson</h4>
                                    <p>Velit asperiores et ducimus soluta repudiandae labore officia est ut...</p>
                                    <p>6 hrs. ago</p>
                                </div>
                            </a>
                        </li>
                        <li>
                            <hr class=""dropdown-divider"">
                        </li>

                        <li class=""message-item"">
                            <a href=""#"">
                                <img src=""/img/messages-3.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 8777, "\"", 8783, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""rounded-circle"">
                                <div>
                                    <h4>David Muldon</h4>
                                    <p>Velit asperiores et ducimus soluta repudiandae labore officia est ut...</p>
                                    <p>8 hrs. ago</p>
                                </div>
                            </a>
                        </li>
                        <li>
                            <hr class=""dropdown-divider"">
                        </li>

                        <li class=""dropdown-footer"">
                            <a href=""#"">Show all messages</a>
                        </li>

                    </ul><!-- End Messages Dropdown Items -->

                </li><!-- End Messages Nav -->

                <li class=""nav-item dropdown pe-3"">

                    <a class=""nav-link nav-profile d-flex align-items-center pe-0"" href=""#"" data-bs-toggle=""dropdown"">
                        <img src=""/img/profile-img.jpg"" alt=""P");
                WriteLiteral(@"rofile"" class=""rounded-circle"">
                        <span class=""d-none d-md-block dropdown-toggle ps-2"">K. Anderson</span>
                    </a><!-- End Profile Iamge Icon -->

                    <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow profile"">
                        <li class=""dropdown-header"">
                            <h6>Kevin Anderson</h6>
                            <span>Web Designer</span>
                        </li>
                        <li>
                            <hr class=""dropdown-divider"">
                        </li>

                        <li>
                            <a class=""dropdown-item d-flex align-items-center"" href=""users-profile.html"">
                                <i class=""bi bi-person""></i>
                                <span>My Profile</span>
                            </a>
                        </li>
                        <li>
                            <hr class=""dropdown-divider"">
                ");
                WriteLiteral(@"        </li>

                        <li>
                            <a class=""dropdown-item d-flex align-items-center"" href=""users-profile.html"">
                                <i class=""bi bi-gear""></i>
                                <span>Account Settings</span>
                            </a>
                        </li>
                        <li>
                            <hr class=""dropdown-divider"">
                        </li>

                        <li>
                            <a class=""dropdown-item d-flex align-items-center"" href=""pages-faq.html"">
                                <i class=""bi bi-question-circle""></i>
                                <span>Need Help?</span>
                            </a>
                        </li>
                        <li>
                            <hr class=""dropdown-divider"">
                        </li>

                        <li>
                            <a class=""dropdown-item d-flex align-items-center"" hre");
                WriteLiteral(@"f=""#"">
                                <i class=""bi bi-box-arrow-right""></i>
                                <span>Sign Out</span>
                            </a>
                        </li>

                    </ul><!-- End Profile Dropdown Items -->
                </li><!-- End Profile Nav -->

            </ul>
        </nav><!-- End Icons Navigation -->

    </header><!-- End Header -->
    <!-- ======= Sidebar ======= -->
    <aside id=""sidebar"" class=""sidebar"">

        <ul class=""sidebar-nav"" id=""sidebar-nav"">

            <li class=""nav-item"">
                <a class=""nav-link "" href=""index.html"">
                    <i class=""bi bi-grid""></i>
                    <span>Dashboard</span>
                </a>
            </li><!-- End Dashboard Nav -->

            

            

            <li class=""nav-item"">
                <a class=""nav-link collapsed"" data-bs-target=""#tables-nav"" data-bs-toggle=""collapse"" href=""#"">
                    <i class=""bi bi-layout-te");
                WriteLiteral(@"xt-window-reverse""></i><span>Tables</span><i class=""bi bi-chevron-down ms-auto""></i>
                </a>
                <ul id=""tables-nav"" class=""nav-content collapse "" data-bs-parent=""#sidebar-nav"">
                    <li>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8d3bb7edeb2cecf2339d6adee661fab80b066f625640", async() => {
                    WriteLiteral("Görevler");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </li>\r\n        </ul>\r\n\r\n    </aside><!-- End Sidebar-->\r\n\r\n        ");
#nullable restore
#line 309 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <!-- Vendor JS Files -->
    <script src=""/vendor/apexcharts/apexcharts.min.js""></script>
    <script src=""/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""/vendor/chart.js/chart.min.js""></script>
    <script src=""/vendor/echarts/echarts.min.js""></script>
    <script src=""/vendor/quill/quill.min.js""></script>
    <script src=""/vendor/simple-datatables/simple-datatables.js""></script>
    <script src=""/vendor/tinymce/tinymce.min.js""></script>
    <script src=""/vendor/php-email-form/validate.js""></script>

    <!-- Template Main JS File -->
    <script src=""/js/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
