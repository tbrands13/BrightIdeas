#pragma checksum "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/OneIdea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5da225a9f0cafe63fd65d94d4517d6234267d262"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneIdea), @"mvc.1.0.view", @"/Views/Home/OneIdea.cshtml")]
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
#line 1 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/_ViewImports.cshtml"
using FinalBeltExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/OneIdea.cshtml"
using FinalBeltExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5da225a9f0cafe63fd65d94d4517d6234267d262", @"/Views/Home/OneIdea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff85e270e6e22e887022f5a38ce1288dc224cde", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneIdea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Idea>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""d-flex justify-content-around"">
    <a href=""/IdeaFeed"" class=""btn btn-lg btn-outline-info"">Bright Ideas</a>
    <a href=""/"" class=""btn btn-lg btn-outline-dark"">Logout</a>
</div>
<br>


    

<div class=""card mb-8"">
    <div class=""card-header"">
        <h5><a");
            BeginWriteAttribute("href", " href=\"", 314, "\"", 321, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/OneIdea.cshtml"
                  Write(ViewBag.OneIdea.Creator.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> says:</h5>\n    </div>\n    <div class=\"card-body\">\n        <p>");
#nullable restore
#line 19 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/OneIdea.cshtml"
      Write(ViewBag.OneIdea.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>
</div>
    
    <div>
        <h4>People who liked this Idea:</h4>
        <table class=""table table-dark table-striped table-hover"">
            <tr>
                <th>Alias</th>
                <th>Name</th>
            </tr>
            
");
#nullable restore
#line 31 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/OneIdea.cshtml"
             foreach (Like idea in ViewBag.OneIdea.Likes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 34 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/OneIdea.cshtml"
               Write(idea.User.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 35 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/OneIdea.cshtml"
               Write(idea.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 37 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/OneIdea.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Idea> Html { get; private set; }
    }
}
#pragma warning restore 1591
