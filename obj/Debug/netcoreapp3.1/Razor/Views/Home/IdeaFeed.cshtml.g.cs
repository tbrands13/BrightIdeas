#pragma checksum "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87fd7ef7ac10857d9437fea5acfd480a28387f29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IdeaFeed), @"mvc.1.0.view", @"/Views/Home/IdeaFeed.cshtml")]
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
#line 1 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
using FinalBeltExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87fd7ef7ac10857d9437fea5acfd480a28387f29", @"/Views/Home/IdeaFeed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff85e270e6e22e887022f5a38ce1288dc224cde", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IdeaFeed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Idea>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("post something witty here..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddIdea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"d-flex justify-content-between\">\n    <h1>Hello, ");
#nullable restore
#line 5 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
          Write(ViewBag.LoggedUser.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\n    <a href=\"/\" class=\"btn btn-lg btn-outline-dark\">Logout</a>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87fd7ef7ac10857d9437fea5acfd480a28387f296182", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "87fd7ef7ac10857d9437fea5acfd480a28387f296444", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 10 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87fd7ef7ac10857d9437fea5acfd480a28387f298095", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 11 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <br>\n        <input type=\"submit\" class=\"btn btn-lg btn-outline-primary\">\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n<br>\n");
#nullable restore
#line 17 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
     foreach(Idea idea in ViewBag.AllIdeas)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\n    <div class=\"card-header\">\n        <h5><a");
            BeginWriteAttribute("href", " href=\"", 685, "\"", 711, 2);
            WriteAttributeValue("", 692, "/users/", 692, 7, true);
#nullable restore
#line 22 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
WriteAttributeValue("", 699, idea.UserId, 699, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
                                     Write(idea.Creator.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> says:</h5>\n    </div>\n    <div class=\"card-body\">\n        <p>");
#nullable restore
#line 25 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
      Write(idea.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        \n    </div>\n    <div class=\"card-footer\">\n        <p><a");
            BeginWriteAttribute("href", " href=\"", 879, "\"", 909, 3);
            WriteAttributeValue("", 886, "/idea/", 886, 6, true);
#nullable restore
#line 29 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
WriteAttributeValue("", 892, idea.IdeaId, 892, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 904, "/like", 904, 5, true);
            EndWriteAttribute();
            WriteLiteral(">Like</a></p>\n        <p><a");
            BeginWriteAttribute("href", " href=\"", 937, "\"", 962, 2);
            WriteAttributeValue("", 944, "/idea/", 944, 6, true);
#nullable restore
#line 30 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
WriteAttributeValue("", 950, idea.IdeaId, 950, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 30 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
                                    Write(idea.Likes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> people like this</p>\n");
#nullable restore
#line 31 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
          
            if(idea.UserId == ViewBag.User)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p><a");
            BeginWriteAttribute("href", " href=\"", 1098, "\"", 1130, 3);
            WriteAttributeValue("", 1105, "/idea/", 1105, 6, true);
#nullable restore
#line 34 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
WriteAttributeValue("", 1111, idea.IdeaId, 1111, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1123, "/delete", 1123, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-danger\">Delete Idea</a></p>\n");
#nullable restore
#line 35 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n<br>\n");
#nullable restore
#line 40 "/Users/tito/Desktop/Coding_Dojo/CSharp/BeltExam/BrightIdeas/Views/Home/IdeaFeed.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Idea> Html { get; private set; }
    }
}
#pragma warning restore 1591
