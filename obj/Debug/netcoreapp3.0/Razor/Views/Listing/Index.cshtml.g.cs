#pragma checksum "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3301e24a22de5d78e6d1e94c23007dab88d64c0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Listing_Index), @"mvc.1.0.view", @"/Views/Listing/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\Nepalists\Views\_ViewImports.cshtml"
using Nepalists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\Nepalists\Views\_ViewImports.cshtml"
using Nepalists.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3301e24a22de5d78e6d1e94c23007dab88d64c0a", @"/Views/Listing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6dafca3bcd4d3f4d6f0d18e2312dc06a06ec2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Listing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Listing>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_IndexView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Description", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Listing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("over-bg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
     if(ViewBag.c!=null)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n\t\t\r\n    <br>\r\n\t\r\n\r\n\t <div class=\"alert alert-success\" role=\"alert\">\r\n  <h4 class=\"alert-heading\">Well done!</h4>\r\n   <p>      </p>\r\n  <hr>\r\n  <p class=\"mb-0\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3301e24a22de5d78e6d1e94c23007dab88d64c0a5740", async() => {
                WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
                                                                   Write(ViewBag.c);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" to start posting your items</p>\r\n</div>\r\n\t\r\n</div>\r\n");
#nullable restore
#line 17 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\r\n\r\n\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3301e24a22de5d78e6d1e94c23007dab88d64c0a7611", async() => {
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
            WriteLiteral(" \r\n<div class=\"row\">\r\n\t\t\t\t\t\r\n\t\t\t\t</div>\t\r\n\r\n\t\t\t\t");
#nullable restore
#line 26 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
           Write(TempData["M"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
				  <!-- Banner Area-->
		<div class=""row"" id=""myBtnContainer"">
				<div class=""col-xl-10 col-lg-10 col-md-8 col-sm-12 px-0"">		
					<ul class=""category-links"">
						<li class=""nav-item""> <a href=""#"" class=""nav-link active"" > All </a></li>
						<li class=""nav-item""> <a href=""#"" class=""nav-link""> Places & Events </a></li>
						<li class=""nav-item""> <a href=""#"" class=""nav-link"">Real Estate </a></li>
						<li class=""nav-item""> <a href=""#"" class=""nav-link"">Cars & Bikes </a></li>
						<li class=""nav-item""> <a href=""#"" class=""nav-link"">Electronic </a></li>
						<li class=""nav-item""> <a href=""#"" class=""nav-link"">Others </a></li>
					</ul>
				</div>
				<div class=""text-right radar col-xl-2 col-lg-2 col-md-4 col-sm-12 p-right px-0"">
					<a href=""map_listing.html""><img src=""images/svg/radar-icon.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1311, "\"", 1317, 0);
            EndWriteAttribute();
            WriteLiteral(@">Map Lisitng</a>
				</div>
		</div>
	<div class=""video-block section-padding"">
        <div class=""row"">
			<div class=""tabby"">
				<div class=""htitle col-md-12"">
					<h5>latest listing</h5>
					<a href=""#"">Show More</a>
				</div>
				<div class=""clearfix""></div>
");
#nullable restore
#line 51 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
 foreach(ListsModel x in ((IEnumerable<ListsModel>)ViewBag.Lists))

{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-xl-3 col-sm-6\">\r\n\t\t\t\t\t<div class=\"box\">\r\n\t\t\t\t\t\t<div class=\"box-img\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3301e24a22de5d78e6d1e94c23007dab88d64c0a10690", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
                                                                                   WriteLiteral(x.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 1874, "\"", 1902, 2);
            WriteAttributeValue("", 1880, "/placeimages/", 1880, 13, true);
#nullable restore
#line 58 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
WriteAttributeValue("", 1893, x.Images, 1893, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img\"");
            BeginWriteAttribute("alt", " alt=\"", 1915, "\"", 1921, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1922, "\"", 1930, 0);
            EndWriteAttribute();
            WriteLiteral(" height=\"200px\" width=\"350px\">\r\n\t\t\t\t\t\t\t<div class=\"box-heading1\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 60 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
                           Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								<div class=""box-heading2"">
								<svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" preserveAspectRatio=""xMidYMid"" width=""12"" height=""14"" class=""location-icon"" viewBox=""0 0 12 14"">
								  <path d=""M6.720,10.847 C6.242,11.332 5.477,11.332 4.998,10.847 C2.719,8.534 1.555,6.413 1.555,4.454 C1.555,1.994 3.482,-0.000 5.859,-0.000 C8.236,-0.000 10.163,1.994 10.163,4.454 C10.163,6.413 8.999,8.534 6.720,10.847 ZM8.934,4.454 C8.934,2.697 7.557,1.273 5.859,1.273 C4.161,1.273 2.785,2.697 2.785,4.454 C2.785,6.004 3.793,7.842 5.859,9.938 C7.925,7.842 8.934,6.004 8.934,4.454 ZM5.859,6.045 C4.840,6.045 4.015,5.191 4.015,4.136 C4.015,3.082 4.840,2.227 5.859,2.227 C6.878,2.227 7.704,3.082 7.704,4.136 C7.704,5.191 6.878,6.045 5.859,6.045 ZM5.859,4.773 C6.199,4.773 6.474,4.488 6.474,4.136 C6.474,3.785 6.199,3.500 5.859,3.500 C5.520,3.500 5.244,3.785 5.244,4.136 C5.244,4.488 5.520,4.773 5.859,4.773 ZM2.165,9.509 C2.483,9.385 2.838,9.552 2.957,9.881 C3.076,10.210 2.915,10.577 2.597");
            WriteLiteral(@",10.700 C1.895,10.973 1.555,11.285 1.555,11.454 C1.555,11.987 3.462,12.727 5.859,12.727 C8.256,12.727 10.163,11.987 10.163,11.454 C10.163,11.285 9.823,10.973 9.122,10.700 C8.804,10.577 8.643,10.210 8.762,9.881 C8.881,9.552 9.235,9.385 9.553,9.509 C10.684,9.948 11.393,10.598 11.393,11.454 C11.393,13.031 8.895,14.000 5.859,14.000 C2.823,14.000 0.326,13.031 0.326,11.454 C0.326,10.598 1.034,9.948 2.165,9.509 Z""></path>
								</svg> ");
#nullable restore
#line 64 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
                                  Write(x.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"favorite\">\r\n\t\t\t\t\t\t\t\t<i >👨</i>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"box-radius\">\r\n\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 3631, "\"", 3657, 2);
            WriteAttributeValue("", 3637, "/userimages/", 3637, 12, true);
#nullable restore
#line 71 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
WriteAttributeValue("", 3649, x.Photo, 3649, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" width=\"50px\" style=\"border-radius: 13px;\" class=\"img\"");
            BeginWriteAttribute("alt", " alt=\"", 3726, "\"", 3732, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3733, "\"", 3741, 0);
            EndWriteAttribute();
            WriteLiteral(" >\t\t\t\t\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"box-heading3\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3301e24a22de5d78e6d1e94c23007dab88d64c0a16905", async() => {
#nullable restore
#line 74 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
                                                                                                     Write(x.User);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
                                                                                   WriteLiteral(x.UserId);

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
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 78 "C:\Users\Lenovo\Desktop\Nepalists\Views\Listing\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\t\r\n\t<!-- container Tab End -->\r\n\t\r\n   \t</div>\r\n\t</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Listing>> Html { get; private set; }
    }
}
#pragma warning restore 1591