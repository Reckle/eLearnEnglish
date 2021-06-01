#pragma checksum "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\GetMusic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58086492ff16db138a9a2238786de71549e9469c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Music_GetMusic), @"mvc.1.0.view", @"/Views/Music/GetMusic.cshtml")]
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
#line 1 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\_ViewImports.cshtml"
using eLearnEnglish_ASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\_ViewImports.cshtml"
using eLearnEnglish_ASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58086492ff16db138a9a2238786de71549e9469c", @"/Views/Music/GetMusic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02d81f4b77b922d53e9a95d72e8cf456129186f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Music_GetMusic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\GetMusic.cshtml"
  
    ViewData["Title"] = "Music detail " + Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <h3 class=\"display-4\">Music details</h3>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <iframe width=\"500\" height=\"315\"");
            BeginWriteAttribute("src", " src=", 256, "", 276, 1);
#nullable restore
#line 11 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\GetMusic.cshtml"
WriteAttributeValue("", 261, Model.MusicUrl, 261, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                    title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay;
                    clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h1>");
#nullable restore
#line 18 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\GetMusic.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 text-primary\">\r\n                    <span class=\"label label-primary\">By: </span>\r\n                    <span class=\"monospaced\">");
#nullable restore
#line 25 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\GetMusic.cshtml"
                                        Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p class=\"description\">\r\n                        ");
#nullable restore
#line 32 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\GetMusic.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral("\r\n            <hr />\r\n\r\n            <ul class=\"list-group\">\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Genre - </span> ");
#nullable restore
#line 48 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\GetMusic.cshtml"
                                                                                      Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Difficulty - </span> ");
#nullable restore
#line 49 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\GetMusic.cshtml"
                                                                                           Write(Model.Difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n\r\n   \r\n\r\n    <hr />\r\n\r\n\r\n</div>\r\n\r\n<div class=\"py-5 bg-light\">\r\n    <div class=\"container\">\r\n\r\n\r\n        ");
#nullable restore
#line 65 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\GetMusic.cshtml"
   Write(await Component.InvokeAsync("DownMusic", new { difficulty = Model.Difficulty }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
