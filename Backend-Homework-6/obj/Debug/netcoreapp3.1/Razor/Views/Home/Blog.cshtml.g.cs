#pragma checksum "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fab9366588773ef939a3fd4e94fc83ff2647fc15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blog), @"mvc.1.0.view", @"/Views/Home/Blog.cshtml")]
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
#line 1 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\_ViewImports.cshtml"
using Backend_Homework_6.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\_ViewImports.cshtml"
using Backend_Homework_6.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fab9366588773ef939a3fd4e94fc83ff2647fc15", @"/Views/Home/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82215537baae59975748d558a075e81d9fe2326f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "blogdetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("readmore stretched-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <div class=""breadcrumbs d-flex align-items-center"" style=""background-image: url('assets/img/breadcrumbs-bg.jpg');"">
        <div class=""container position-relative d-flex flex-column align-items-center"" data-aos=""fade"">

            <h2>Blog</h2>
            <ol>
                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fab9366588773ef939a3fd4e94fc83ff2647fc154836", async() => {
                WriteLiteral("Home");
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
            WriteLiteral(@"</li>
                <li>Blog</li>
            </ol>

        </div>
    </div><!-- End Breadcrumbs -->
    <!-- ======= Blog Section ======= -->
    <section id=""blog"" class=""blog"">
        <div class=""container"" data-aos=""fade-up"" data-aos-delay=""100"">

            <div class=""row gy-4 posts-list"">

");
#nullable restore
#line 23 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
                 foreach (Blog blog in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-xl-4 col-md-6\">\r\n                        <div class=\"post-item position-relative h-100\">\r\n\r\n                            <div class=\"post-img position-relative overflow-hidden\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1060, "\"", 1081, 1);
#nullable restore
#line 29 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
WriteAttributeValue("", 1066, blog.Thumbnail, 1066, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 1100, "\"", 1117, 1);
#nullable restore
#line 29 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
WriteAttributeValue("", 1106, blog.Title, 1106, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                                <span class=\"post-date\">");
#nullable restore
#line 32 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
                                                   Write(blog.ReleaseDate.ToString("dd/MMMM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n\r\n                            <div class=\"post-content d-flex flex-column\">\r\n\r\n                                <h3 class=\"post-title\">");
#nullable restore
#line 37 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
                                                  Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                                <div class=\"meta d-flex align-items-center\">\r\n                                    <div class=\"d-flex align-items-center\">\r\n                                        <i class=\"bi bi-person\"></i> <span class=\"ps-2\">");
#nullable restore
#line 41 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
                                                                                   Write(blog.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                    <span class=""px-3 text-black-50"">/</span>
                                    <div class=""d-flex align-items-center"">
                                        <i class=""bi bi-folder2""></i> <span class=""ps-2"">Politics</span>
                                    </div>
                                    <span class=""px-3 text-black-50"">/</span>

                                    <div class=""d-flex align-items-center"">
                                        <i class=""bi bi-ui-radios""></i>
");
#nullable restore
#line 52 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
                                          
                                            if (blog.Comments.Count == 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"ps-2\">\r\n                                                    No comments\r\n                                                </span>\r\n");
#nullable restore
#line 58 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
                                            }
                                            else if (blog.Comments.Count == 1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"ps-2\">\r\n                                                    ");
#nullable restore
#line 62 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
                                                Write($"{blog.Comments.Count} comment");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </span>\r\n");
#nullable restore
#line 64 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"ps-2\">\r\n                                                    ");
#nullable restore
#line 68 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
                                                Write($"{blog.Comments.Count} comments");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </span>          \r\n");
#nullable restore
#line 70 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n\r\n                                </div>\r\n\r\n                                <p>\r\n                                       ");
#nullable restore
#line 77 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
                                   Write(blog.Description.Length>=100 ? @blog.Description.Substring(0, 100) : blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                      <hr>\r\n                                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fab9366588773ef939a3fd4e94fc83ff2647fc1513345", async() => {
                WriteLiteral("<span>Read More</span><i class=\"bi bi-arrow-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"
                                                                                          WriteLiteral(blog.Id);

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
            WriteLiteral("\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div><!-- End post list item -->\r\n");
#nullable restore
#line 86 "C:\Users\efend\source\repos\Backend\Backend-Homeworks\Backend-Homework-6\Backend-Homework-6\Views\Home\Blog.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div><!-- End blog posts list -->

            <div class=""blog-pagination"">
                <ul class=""justify-content-center"">
                    <li><a href=""#"">1</a></li>
                    <li class=""active""><a href=""#"">2</a></li>
                    <li><a href=""#"">3</a></li>
                </ul>
            </div><!-- End blog pagination -->

        </div>
    </section><!-- End Blog Section -->

</main><!-- End #main -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
