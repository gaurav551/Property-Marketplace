#pragma checksum "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\FindProfiles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ad7c9a01573a0d8ed64f84da920f5ff6253e3f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_FindProfiles), @"mvc.1.0.view", @"/Views/Profile/FindProfiles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/FindProfiles.cshtml", typeof(AspNetCore.Views_Profile_FindProfiles))]
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
#line 1 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\_ViewImports.cshtml"
using Nepalists;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\_ViewImports.cshtml"
using Nepalists.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ad7c9a01573a0d8ed64f84da920f5ff6253e3f0", @"/Views/Profile/FindProfiles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6dafca3bcd4d3f4d6f0d18e2312dc06a06ec2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_FindProfiles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Profile>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FindProfiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 366, true);
            WriteLiteral(@"
<div class=""video-block section-padding"">
						<div class=""main-items"">
							<div class=""row justify-content-md-center"">
								<div class=""messages text-center col-md-12"">
									Find Profiles
									<hr>
								</div>
								
								<div class=""feedback col-md-12"">
																										
									<div class=""search-people"">
										");
            EndContext();
            BeginContext(388, 291, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ad7c9a01573a0d8ed64f84da920f5ff6253e3f05096", async() => {
                BeginContext(458, 214, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"search\" class=\"search-people-input\" id=\"search\" name=\"search\" placeholder=\"Search peoples...\">\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"submit\" value=\"Search\" class=\"people-search\"/>\r\n\t\t\t\t\t\t\t\t\t\t");
                EndContext();
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(679, 178, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t</div>\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"my-all-lisitngs\">\r\n\t\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t\t\r\n");
            EndContext();
#line 27 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\FindProfiles.cshtml"
                                     foreach(var x in Model)
									{

#line default
#line hidden
            BeginContext(904, 165, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"col-lg-3 col-sm-12\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"my-listing-dt-all-follow\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\" my-lisiting-picy\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"#\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1069, "\"", 1098, 2);
            WriteAttributeValue("", 1075, "/userimages/", 1075, 12, true);
#line 32 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\FindProfiles.cshtml"
WriteAttributeValue("", 1087, x.ImageUrl, 1087, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1099, 44, true);
            WriteLiteral(" alt=\"\"></a>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1143, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ad7c9a01573a0d8ed64f84da920f5ff6253e3f08780", async() => {
                BeginContext(1221, 4, true);
                WriteLiteral("<h4>");
                EndContext();
                BeginContext(1226, 10, false);
#line 34 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\FindProfiles.cshtml"
                                                                                                                         Write(x.FullName);

#line default
#line hidden
                EndContext();
                BeginContext(1236, 5, true);
                WriteLiteral("</h4>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\FindProfiles.cshtml"
                                                                                                   WriteLiteral(x.UserId);

#line default
#line hidden
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
            EndContext();
            BeginContext(1245, 54, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t<p> <i class=\"fas fa-map-marker-alt\"></i>");
            EndContext();
            BeginContext(1300, 9, false);
#line 35 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\FindProfiles.cshtml"
                                                                                Write(x.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1309, 180, true);
            WriteLiteral(" </p>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"dashboard-main-dt-follow\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"lisitng-dt2\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<ins>");
            EndContext();
            BeginContext(1490, 9, false);
#line 40 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\FindProfiles.cshtml"
                                                            Write(x.Listing);

#line default
#line hidden
            EndContext();
            BeginContext(1499, 198, true);
            WriteLiteral("</ins>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span>Listings</span>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"lisitng-dt2\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<ins>");
            EndContext();
            BeginContext(1698, 16, false);
#line 46 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\FindProfiles.cshtml"
                                                            Write(x.FollowersCount);

#line default
#line hidden
            EndContext();
            BeginContext(1714, 465, true);
            WriteLiteral(@"</ins>															
															<span>Followers</span>															
														</div>
													</li>
													<li>
														<div class=""lisitng-dt2"">
															<ins></ins>															
															<span>Following</span>															
														</div>
													</li>
												</ul>
											</div>
											<button class=""folow-btn"" type=""button"">See Listings</button>
										</div>
									</div>
");
            EndContext();
#line 61 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\FindProfiles.cshtml"
									}

#line default
#line hidden
            BeginContext(2191, 290, true);
            WriteLiteral(@"																									
								</div>														
							</div>
							<div class=""view-spinner"">
								<div class=""spinner-border"" role=""status"">
									<span class=""sr-only"">Loading...</span>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Profile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
