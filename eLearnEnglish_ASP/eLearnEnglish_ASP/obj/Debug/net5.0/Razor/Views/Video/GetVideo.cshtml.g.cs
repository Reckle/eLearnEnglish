#pragma checksum "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Video\GetVideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cb3dde1c61674801b9a7a4978cc17106a10705e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Video_GetVideo), @"mvc.1.0.view", @"/Views/Video/GetVideo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cb3dde1c61674801b9a7a4978cc17106a10705e", @"/Views/Video/GetVideo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02d81f4b77b922d53e9a95d72e8cf456129186f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Video_GetVideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Video\GetVideo.cshtml"
  
    ViewData["Title"] = "Video detail " + Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <h3 class=""display-4"">Book details</h3>
    <div class=""row"">
        <div class=""col-md-6"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">

");
            WriteLiteral("                </ol>\r\n                <div class=\"carousel-inner\">\r\n");
            WriteLiteral(@"
                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h1>");
#nullable restore
#line 41 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Video\GetVideo.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p class=\"description\">\r\n                        ");
#nullable restore
#line 55 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Video\GetVideo.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-md-4"">
                    <a class=""btn btn-outline-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
                        Watch now
                    </a>
                </div>
            </div>

            <hr />

            <ul class=""list-group"">
                <li class=""list-group-item""><span class=""font-weight-bold"">Difficulty - </span> ");
#nullable restore
#line 71 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Video\GetVideo.cshtml"
                                                                                           Write(Model.Difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n    <hr />\r\n\r\n    <div class=\"py-5 bg-light\" id=\"similarBooks\">\r\n        <h3 class=\"h3\">Similar books</h3>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 83 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Video\GetVideo.cshtml"
             for (int i = 0; i < 5; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-4"">
                    <div class=""card mb-4 shadow-sm"">
                        <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: Thumbnail""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""></rect><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
                        <div class=""card-body"">
                            <h3 class=""card-title"">book.Title</h3>
                            <p class=""card-text"">book.Description</p>
                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""btn-group"">
                                    <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View details</a>
                                </div>
                                <small class=""text-muted"">bo");
            WriteLiteral("ok.Author</small>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 100 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Video\GetVideo.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
