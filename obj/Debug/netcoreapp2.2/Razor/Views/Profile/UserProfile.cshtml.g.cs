#pragma checksum "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3f00d29e47aa778d90bd91b15d53aa6c092589b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_UserProfile), @"mvc.1.0.view", @"/Views/Profile/UserProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/UserProfile.cshtml", typeof(AspNetCore.Views_Profile_UserProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3f00d29e47aa778d90bd91b15d53aa6c092589b", @"/Views/Profile/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6dafca3bcd4d3f4d6f0d18e2312dc06a06ec2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Profile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Follow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:White;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Listing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyListings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
 if(Model == null)
{
 
     

#line default
#line hidden
            BeginContext(51, 99, true);
            WriteLiteral("<div class=\"alert alert-danger\" role=\"alert\">\r\n This user\'s havent created a profile yet \r\n</div>\r\n");
            EndContext();
#line 10 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
}
else
{




#line default
#line hidden
            BeginContext(168, 227, true);
            WriteLiteral("<div class=\"video-block section-padding\">\r\n\t<div class=\"main-item\">\r\n\t\t<div class=\"row\">\r\n\t\t    <div class=\"col-md-12 px-0\">\r\n\t\t\t\t<div class=\"profile-area-dashboard\">\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t<div class=\" my-dash-profile\">\r\n\t\t\t\t\t <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 395, "\"", 428, 2);
            WriteAttributeValue("", 401, "/userimages/", 401, 12, true);
#line 23 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
WriteAttributeValue("", 413, Model.ImageUrl, 413, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(429, 138, true);
            WriteLiteral(" alt=\"\">\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"profile-dashbd-dt\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"item-title-dashbd\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h4> ");
            EndContext();
            BeginContext(568, 14, false);
#line 27 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(582, 73, true);
            WriteLiteral(" </h4>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<p><span><i class=\"fas fa-map-marker-alt\"></i></span>");
            EndContext();
            BeginContext(656, 13, false);
#line 28 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                                                                Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(669, 190, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"dashboard-main-dt\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"lisitng-dtl\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<ins> ");
            EndContext();
            BeginContext(860, 17, false);
#line 34 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                             Write(ViewBag.ListCount);

#line default
#line hidden
            EndContext();
            BeginContext(877, 198, true);
            WriteLiteral("</ins>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span>Listings</span>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"lisitng-dtl\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<ins>");
            EndContext();
            BeginContext(1076, 9, false);
#line 40 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                            Write(ViewBag.c);

#line default
#line hidden
            EndContext();
            BeginContext(1085, 199, true);
            WriteLiteral("</ins>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span>Followers</span>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"lisitng-dtl\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<ins>");
            EndContext();
            BeginContext(1285, 10, false);
#line 46 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                            Write(ViewBag.c1);

#line default
#line hidden
            EndContext();
            BeginContext(1295, 210, true);
            WriteLiteral("</ins>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span>Following</span>\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<button class=\"setting-btn\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1505, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3f00d29e47aa778d90bd91b15d53aa6c092589b9645", async() => {
                BeginContext(1644, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1646, 13, false);
#line 53 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                                                                                                                                                       Write(TempData["c"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                                                                      WriteLiteral(Model.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                                                                                                         WriteLiteral(Model.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1663, 77, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t\t\t\t\t\t<button class=\"setting-btn\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1740, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3f00d29e47aa778d90bd91b15d53aa6c092589b13650", async() => {
                BeginContext(1811, 5, true);
                WriteLiteral(" Like");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1820, 808, true);
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
            EndContext();
            BeginContext(2629, 14, false);
#line 80 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                                       Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(2643, 66, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(2710, 10, false);
#line 82 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                                      Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2720, 399, true);
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
            EndContext();
            BeginContext(3120, 11, false);
#line 94 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                                       Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(3131, 388, true);
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
            EndContext();
            BeginContext(3520, 11, false);
#line 106 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                                   Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3531, 390, true);
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
            EndContext();
            BeginContext(3922, 13, false);
#line 118 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                                       Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(3935, 392, true);
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
            EndContext();
            BeginContext(4328, 14, false);
#line 130 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                                       Write(Model.Address2);

#line default
#line hidden
            EndContext();
            BeginContext(4342, 289, true);
            WriteLiteral(@"
																		</div>				
																	</div>
																	<div class=""user-reply"">
																		<div class=""heading1"">
																			
																			<h3>
																				Member Since																			
																			</h3>
																			<p>");
            EndContext();
            BeginContext(4632, 10, false);
#line 139 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                                                          Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(4642, 429, true);
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
            EndContext();
            BeginContext(5072, 14, false);
#line 160 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
   Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(5086, 17, true);
            WriteLiteral(" You have posted ");
            EndContext();
            BeginContext(5104, 17, false);
#line 160 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"
                                   Write(ViewBag.ListCount);

#line default
#line hidden
            EndContext();
            BeginContext(5121, 26, true);
            WriteLiteral(" Listings(s) <span> Click ");
            EndContext();
            BeginContext(5147, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3f00d29e47aa778d90bd91b15d53aa6c092589b22049", async() => {
                BeginContext(5199, 3, true);
                WriteLiteral("Me ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5206, 27, true);
            WriteLiteral(" To View </span>!\r\n</div>\r\n");
            EndContext();
#line 162 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\UserProfile.cshtml"



}

#line default
#line hidden
            BeginContext(5240, 11, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591
