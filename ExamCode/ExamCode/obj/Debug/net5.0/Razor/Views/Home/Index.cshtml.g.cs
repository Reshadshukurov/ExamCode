#pragma checksum "C:\Users\exam\Desktop\ExamCode\ExamCode\ExamCode\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e50a47d3cccdc8449aaad7fd183d613d25a709f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\exam\Desktop\ExamCode\ExamCode\ExamCode\Views\_ViewImports.cshtml"
using ExamCode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\exam\Desktop\ExamCode\ExamCode\ExamCode\Views\_ViewImports.cshtml"
using ExamCode.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\exam\Desktop\ExamCode\ExamCode\ExamCode\Views\Home\Index.cshtml"
using ExamCode.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e50a47d3cccdc8449aaad7fd183d613d25a709f2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f632db2a03d9895de70843308cc31ec9ef6939a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <section class=""section-one"">
        <div class=""section-one-div"">
            <span>GET PAGE DONE</span><br><br>
            <h2>It take efforts</h2><br>
            <h3>Lorem ipsum dolor sit ametLorem ipsum dolor sit amet</h3><br>
        </div>
        <button type=""button"" class=""btn btn-danger dowload"">DOWNLOAD THIS THEME NOW!</button>
    </section>
    <section>
        <div class=""section-three"">
            <div class=""container"">
                <h1>OUR SERVICES :</h1>
                <div class=""row"">
                
                    <div class=""col-md-6 col-12"">
                        <h2>Lorem ipsum dolor sit amet</h2>
                        <span>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.</span>
                    </div>
                    <div class=""col-md-6 col-12"">
 ");
            WriteLiteral(@"                       <h2>Lorem ipsum dolor sit amet</h2>
                        <span>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.</span>
                    </div>
                </div>
                <div class=""row g-4 banner-row"">
");
#nullable restore
#line 29 "C:\Users\exam\Desktop\ExamCode\ExamCode\ExamCode\Views\Home\Index.cshtml"
                     foreach (Service item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-4 banner\">\r\n                            <i");
            BeginWriteAttribute("class", " class=\"", 1668, "\"", 1686, 1);
#nullable restore
#line 32 "C:\Users\exam\Desktop\ExamCode\ExamCode\ExamCode\Views\Home\Index.cshtml"
WriteAttributeValue("", 1676, item.Icon, 1676, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            <h2>");
#nullable restore
#line 33 "C:\Users\exam\Desktop\ExamCode\ExamCode\ExamCode\Views\Home\Index.cshtml"
                           Write(item.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <span>");
#nullable restore
#line 34 "C:\Users\exam\Desktop\ExamCode\ExamCode\ExamCode\Views\Home\Index.cshtml"
                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br><br>\r\n                            <span>");
#nullable restore
#line 35 "C:\Users\exam\Desktop\ExamCode\ExamCode\ExamCode\Views\Home\Index.cshtml"
                             Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n");
#nullable restore
#line 37 "C:\Users\exam\Desktop\ExamCode\ExamCode\ExamCode\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <h2>Lorem ipsum dolor sit amet</h2>
                <span>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.</span>
            </div>
        </div>
    </section>
    <section class=""wall"">
        <div class=""container"">
            <div class="" row section-four"">
                <div class=""col-9"">
            ");
            WriteLiteral(@"        <h2>Featured In Wall Street</h2>
                    <h3>and many other magzines..</h3>
                </div>
                <div class=""col-2"">
                    <h2>300+</h2>
                    <h3>Reports</h3>
                </div>
            </div>
        </div>
    </section>
    <section class=""section-five"">
        <div class=""projects"">
            <div class=""container"">
                <div class=""row section-four"">
                    <div class=""col-md-3 col-12"">
                        <h2>5000+</h2>
                        <h3>Projects</h3>
                    </div>
                    <div class=""col-md-3 col-12"">
                        <h2>205+</h2>
                        <h3>Countries</h3>
                    </div>
                    <div class=""col-md-3 col-12"">
                        <h2>1300+</h2>
                        <h3>Offices</h3>
                    </div>
                    <div class=""col-md-3 col-12"">
                        <h2");
            WriteLiteral(@">2400+</h2>
                        <h3>Clients</h3>
                    </div>
                </div>
            </div>
        </div>
        <section>
            <div class=""services"">
                <div class=""container"">
                    <h1>CONTACT US :</h1>
                    <div class=""row"">
                        <div class=""col-md-6 col-12"">
                            <h2>Lorem ipsum dolor sit amet</h2>
                            <span>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.</span>
                        </div>
                        <div class=""col-md-6 col-12"">
                            <h2>Lorem ipsum dolor sit amet</h2>
                            <span>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere. L");
            WriteLiteral(@"orem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.</span>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section class=""contact-us"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6 col-12"">
                        <div class=""row"">
                            <div class=""col-md-6 col-12"">
                                <input type=""text"" class=""input"" placeholder=""Name"">
                            </div>
                            <div class=""col-md-6 col-12"">
                                <input type=""text"" class=""input"" placeholder=""Email address"">
                            </div>
                            <div class=""row"">
                                <div class=""col-12 message"">
                                    <textarea");
            BeginWriteAttribute("name", " name=\"", 5967, "\"", 5974, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input\"");
            BeginWriteAttribute("id", " id=\"", 5989, "\"", 5994, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Message"" style=""width: 400px; height: 50px;""></textarea>
                                </div>
                            </div>
                        </div>
                        <div>
                            <button type=""button"" class=""btn btn-primary submit"">Submit Request</button>
                        </div>
                    </div>

                    <div class=""col-md-6 col-12"">
                        <div>
                            <span><b>Address:</b>  123,Your locality , Counrty Name, Pin-20100090.</span>
                        </div>
                        <div>
                            <span><b>Email: </b> info@yourdomain.com</span>
                        </div>
                        <div>
                            <span><b>Web:</b> www.yourdomain.com</span>
                        </div>
                        <div>
                            <span> <b>Mobile:</b> +00-909-808-707-00</span>
                        </div>
        ");
            WriteLiteral(@"            </div>
                </div>
            </div>
        </section>
        <footer>
            <div class=""footer"">
                <span>2015 www.yourdomain.com | All Right Reserved | Terms | Policies | Licenses</span>
            </div>
        </footer>
    </section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591