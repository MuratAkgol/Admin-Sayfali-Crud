#pragma checksum "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6f787c0561271ed76d550bc40a966585fde2ac9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Update), @"mvc.1.0.view", @"/Views/Task/Update.cshtml")]
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
#nullable restore
#line 1 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6f787c0561271ed76d550bc40a966585fde2ac9", @"/Views/Task/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Task_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tasks>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    #ust{
        margin-top:10%;
    }
</style>

<div class=""container"" id=""ust"">
    <div class=""row"">
        <div class=""col-3""></div>
        <div class=""col"">
            <h2 class=""h2"">Görevi Güncelle</h2>
        </div>
    </div>
    
    <div class=""row"">
        <div class=""col-3""></div>
        <div class=""col"">
");
#nullable restore
#line 21 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
             using(Html.BeginForm("Update", "Task", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 24 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
               Write(Html.Label("Görevin Başlığı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    ");
#nullable restore
#line 25 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
               Write(Html.TextBoxFor(x=>x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 26 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
               Write(Html.ValidationMessageFor(x=>x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br>\r\n                    ");
#nullable restore
#line 28 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
               Write(Html.Label("Görevin İçeriği"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    ");
#nullable restore
#line 29 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
               Write(Html.TextAreaFor(x=>x.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     ");
#nullable restore
#line 30 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
                Write(Html.ValidationMessageFor(x=>x.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br>\r\n                    ");
#nullable restore
#line 32 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
               Write(Html.Label("Görevin Sahibi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    ");
#nullable restore
#line 33 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
               Write(Html.TextBoxFor(x=>x.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br>\r\n                    ");
#nullable restore
#line 35 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
               Write(Html.Label("Görev Durumu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    ");
#nullable restore
#line 36 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
               Write(Html.DropDownList("status",null,"Lütfen bir durum seçiniz."));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br><br />\r\n                    <button class=\"btn btn-outline-success\">Güncelle</button>\r\n                </div>\r\n");
#nullable restore
#line 40 "D:\C# kurs\DersLer\Rea\C#\ReaSinav\Admin\Views\Task\Update.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tasks> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
