#pragma checksum "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f757f47cbe827b9da5a839bd3f1f8594e3cb12c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\_ViewImports.cshtml"
using Nepalists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\_ViewImports.cshtml"
using Nepalists.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f757f47cbe827b9da5a839bd3f1f8594e3cb12c8", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6dafca3bcd4d3f4d6f0d18e2312dc06a06ec2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Profile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:White;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Listing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyListings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
 if(Model == null)
{
 
     

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger\" role=\"alert\">\r\n  Why Havent You created a profile yet? <span> Click ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f757f47cbe827b9da5a839bd3f1f8594e3cb12c85869", async() => {
                WriteLiteral("Me ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" To Create A new One </span>!\r\n</div>\r\n");
#nullable restore
#line 10 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
}
else
{




#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"video-block section-padding\">\r\n\t<div class=\"main-item\">\r\n\t\t<div class=\"row\">\r\n\t\t    <div class=\"col-md-12 px-0\">\r\n\t\t\t\t<div class=\"profile-area-dashboard\">\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t<div class=\" my-dash-profile\">\r\n\t\t\t\t\t <img");
            BeginWriteAttribute("src", " src=\"", 494, "\"", 527, 2);
            WriteAttributeValue("", 500, "/userimages/", 500, 12, true);
#nullable restore
#line 23 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
WriteAttributeValue("", 512, Model.ImageUrl, 512, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 528, "\"", 534, 0);
            EndWriteAttribute();
            WriteLiteral(">\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"profile-dashbd-dt\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"item-title-dashbd\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h4> ");
#nullable restore
#line 27 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<p><span><i class=\"fas fa-map-marker-alt\"></i></span>");
#nullable restore
#line 28 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                                                                Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"dashboard-main-dt\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"lisitng-dtl\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<ins> ");
#nullable restore
#line 34 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                             Write(ViewBag.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</ins>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span style=\"color:White;\">Listings</span>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"lisitng-dtl\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<ins>");
#nullable restore
#line 40 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                            Write(ViewBag.c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</ins>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span> <a href=\"#\" style=\"color:White;\">Followers</a></span>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"lisitng-dtl\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<ins>");
#nullable restore
#line 46 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                            Write(ViewBag.c1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</ins>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span><a href=\"#\" style=\"color:White;\">Following</a></span>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<button class=\"setting-btn\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f757f47cbe827b9da5a839bd3f1f8594e3cb12c811344", async() => {
                WriteLiteral(" Edit ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                                                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t\t\t\t\t\t<button class=\"setting-btn\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f757f47cbe827b9da5a839bd3f1f8594e3cb12c813951", async() => {
                WriteLiteral("Setting ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
												</button>
										</div>										
									</div>										
								</div>									
							</div>
								
								<!-- Profile Detail Area End-->
								<!--Nav Tabs Start -->
								<div class=""row"">
									<div class=""dashbd-detail-tabs"">
										<div class=""col-xl-12 com-md-12 col-sm-12 px-0"">		
											
											<!--Tabs Panes Start -->
											<div class=""tab-content"">												
												<div class=""tab-pane active"" role=""tabpanel"" id=""activity""> 
													<div class=""video-block section-padding"">
														<div class=""row lr-row"">
															<div class=""col-md-12"">
																
																<div class="" locatins"">
																	<div class=""heading1"">
																		
																		<h3>
																			");
#nullable restore
#line 80 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                                       Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 82 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                                      Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
																	</div>																	
																	
																	<div class=""user-reply"">
																		<div class=""heading1"">
																			
																			<h3>
																				Phone																				
																			</h3>
																			
																		</div>																	
																		<div class=""sub-heading"">
																			");
#nullable restore
#line 94 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                                       Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
																		</div>				
																	</div>
																	<div class=""user-reply"">
																		<div class=""heading1"">
																			
																			<h3>
																				Email																				
																			</h3>
																			
																		</div>																	
																		<div class=""sub-heading"">
																		");
#nullable restore
#line 106 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
																		</div>				
																	</div>
																	<div class=""user-reply"">
																		<div class=""heading1"">
																			
																			<h3>
																				Address																			
																			</h3>
																			
																		</div>																	
																		<div class=""sub-heading"">
																			");
#nullable restore
#line 118 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
																		</div>				
																	</div>
																	<div class=""user-reply"">
																		<div class=""heading1"">
																			
																			<h3>
																				Address2																				
																			</h3>
																			
																		</div>																	
																		<div class=""sub-heading"">
																			");
#nullable restore
#line 130 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                                       Write(Model.Address2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
																		</div>				
																	</div>
																	<div class=""user-reply"">
																		<div class=""heading1"">
																			
																			<h3>
																				Member Since																			
																			</h3>
																			<p>");
#nullable restore
#line 139 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                                                          Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
																		</div>																	
																		<div class=""sub-heading"">
																			
																		</div>				
																	</div>


																</div>
															</div>
														</div>
													</div>
												</div>
											</div>
										</div>
									</div>
								</div>
	</div>
	
</div>
<div class=""alert alert-danger"" role=""alert"">
  Hello ");
#nullable restore
#line 160 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" You have posted ");
#nullable restore
#line 160 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"
                                   Write(ViewBag.count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Listings(s) <span> Click ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f757f47cbe827b9da5a839bd3f1f8594e3cb12c821135", async() => {
                WriteLiteral("Me ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" To View </span>!\r\n</div>\r\n");
#nullable restore
#line 162 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Index.cshtml"



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591
