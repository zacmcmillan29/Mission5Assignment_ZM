#pragma checksum "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission5Assignment_ZM/Mission5Assignment_ZM/Mission4Assignment_ZM/Views/Home/Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4339f950b2df700f6498bb45b789fc25ffcf8a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirmation), @"mvc.1.0.view", @"/Views/Home/Confirmation.cshtml")]
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
#line 1 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission5Assignment_ZM/Mission5Assignment_ZM/Mission4Assignment_ZM/Views/_ViewImports.cshtml"
using Mission4Assignment_ZM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission5Assignment_ZM/Mission5Assignment_ZM/Mission4Assignment_ZM/Views/_ViewImports.cshtml"
using Mission4Assignment_ZM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4339f950b2df700f6498bb45b789fc25ffcf8a7", @"/Views/Home/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80da12118e7b4ebeb72dc3f96ee6544c602ccae2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mission4Assignment_ZM.Models.MovieAdd>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission5Assignment_ZM/Mission5Assignment_ZM/Mission4Assignment_ZM/Views/Home/Confirmation.cshtml"
  
    ViewData["Title"] = "Movie Submitted";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n");
#nullable restore
#line 8 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission5Assignment_ZM/Mission5Assignment_ZM/Mission4Assignment_ZM/Views/Home/Confirmation.cshtml"
 if (Model.CategoryId == 5)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>WOW! You still have a VHS? Impressive!</h2>\n    <br />\n    <p>");
#nullable restore
#line 12 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission5Assignment_ZM/Mission5Assignment_ZM/Mission4Assignment_ZM/Views/Home/Confirmation.cshtml"
  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been added to the movie collection! ");
#nullable restore
#line 12 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission5Assignment_ZM/Mission5Assignment_ZM/Mission4Assignment_ZM/Views/Home/Confirmation.cshtml"
                                                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is a great movie!</p>\n");
#nullable restore
#line 13 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission5Assignment_ZM/Mission5Assignment_ZM/Mission4Assignment_ZM/Views/Home/Confirmation.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 17 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission5Assignment_ZM/Mission5Assignment_ZM/Mission4Assignment_ZM/Views/Home/Confirmation.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been added to the movie collection! ");
#nullable restore
#line 17 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission5Assignment_ZM/Mission5Assignment_ZM/Mission4Assignment_ZM/Views/Home/Confirmation.cshtml"
                                                        Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is a great movie!</h2>\n");
#nullable restore
#line 18 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission5Assignment_ZM/Mission5Assignment_ZM/Mission4Assignment_ZM/Views/Home/Confirmation.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mission4Assignment_ZM.Models.MovieAdd> Html { get; private set; }
    }
}
#pragma warning restore 1591
