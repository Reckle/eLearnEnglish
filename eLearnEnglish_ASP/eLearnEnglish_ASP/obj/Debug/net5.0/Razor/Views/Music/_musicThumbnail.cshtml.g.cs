#pragma checksum "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\_musicThumbnail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "207da4b4bbba865dc2a25ac69d6c7e388bf0e5c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Music__musicThumbnail), @"mvc.1.0.view", @"/Views/Music/_musicThumbnail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"207da4b4bbba865dc2a25ac69d6c7e388bf0e5c8", @"/Views/Music/_musicThumbnail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02d81f4b77b922d53e9a95d72e8cf456129186f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Music__musicThumbnail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "musicDetailsRoute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"card mb-4 shadow-sm\">\n    <img");
            BeginWriteAttribute("src", " src=\"", 61, "\"", 157, 1);
#nullable restore
#line 4 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\_musicThumbnail.cshtml"
WriteAttributeValue("", 67, string.IsNullOrEmpty(Model.CoverImageUrl) ? "/images/noimage.png" : Model.CoverImageUrl, 67, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\" />\n    <div class=\"card-body\">\n        <h3 class=\"card-title\">");
#nullable restore
#line 6 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\_musicThumbnail.cshtml"
                           Write(string.IsNullOrEmpty(Model.Title) ? "Name is not available" : Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <p class=\"card-text\">");
#nullable restore
#line 7 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\_musicThumbnail.cshtml"
                         Write(string.IsNullOrEmpty(Model.Description) ? "Description is not availabe": Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <div class=\"d-flex justify-content-between align-items-center\">\n            <div class=\"btn-group\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "207da4b4bbba865dc2a25ac69d6c7e388bf0e5c85289", async() => {
                WriteLiteral("View details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\_musicThumbnail.cshtml"
                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            <small class=\"text-muted\">");
#nullable restore
#line 13 "D:\projects\C#\ASP\eLearnEnglish\eLearnEnglish_ASP\eLearnEnglish_ASP\Views\Music\_musicThumbnail.cshtml"
                                  Write(string.IsNullOrEmpty(Model.Author) ? "NA" : Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n        </div>\n    </div>\n</div>");
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
