#pragma checksum "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Followers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d66c0a60a0d68182650491082e6e1789b8f13472"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Followers), @"mvc.1.0.view", @"/Views/Profile/Followers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Followers.cshtml", typeof(AspNetCore.Views_Profile_Followers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d66c0a60a0d68182650491082e6e1789b8f13472", @"/Views/Profile/Followers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6dafca3bcd4d3f4d6f0d18e2312dc06a06ec2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Followers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Follower>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 34, true);
            WriteLiteral("\r\n\r\nyour followers\r\n<hr>\r\n<br>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Followers.cshtml"
     foreach(var x in Model)
    {
       

#line default
#line hidden
            BeginContext(103, 64, true);
            WriteLiteral("        <div class=\"alert alert-dark\" role=\"alert\">\r\n           ");
            EndContext();
            BeginContext(168, 10, false);
#line 12 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Followers.cshtml"
      Write(x.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(178, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 14 "C:\Users\Lenovo\Desktop\.Net Projects\Nepalists\Views\Profile\Followers.cshtml"
        
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Follower>> Html { get; private set; }
    }
}
#pragma warning restore 1591
