#pragma checksum "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44cc88ebc50e03087849b81eb9d44831b08ee253"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44cc88ebc50e03087849b81eb9d44831b08ee253", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cea0b69009b88ab3ec4971304cbc0ce8380b1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FooterVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<footer>
    <section id=""footer-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-6 col-sm-12"">
                    <div class=""footer-side"">
                        <div class=""footer-info"">
                            <h1>Category</h1>
                            <ul>
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 424, "\"", 431, 0);
            EndWriteAttribute();
            WriteLiteral(">Male</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 486, "\"", 493, 0);
            EndWriteAttribute();
            WriteLiteral(">Female</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 550, "\"", 557, 0);
            EndWriteAttribute();
            WriteLiteral(">Shoes</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 613, "\"", 620, 0);
            EndWriteAttribute();
            WriteLiteral(@">Fashion</a></li>
                            </ul>

                        </div>
                    </div>

                </div>
                <div class=""col-lg-3 col-md-6 col-sm-12"">
                    <div class=""footer-side"">
                        <div class=""footer-info"">
                            <h1>Company</h1>
                            <ul>
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1038, "\"", 1045, 0);
            EndWriteAttribute();
            WriteLiteral(">About</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1101, "\"", 1108, 0);
            EndWriteAttribute();
            WriteLiteral(">News</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1163, "\"", 1170, 0);
            EndWriteAttribute();
            WriteLiteral(">FAQ</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1224, "\"", 1231, 0);
            EndWriteAttribute();
            WriteLiteral(@">Contact</a></li>
                            </ul>

                        </div>
                    </div>

                </div>
                <div class=""col-lg-3 col-md-6 col-sm-12"">
                    <div class=""footer-side"">
                        <div class=""footer-info"">
                            <h1>Address</h1>
                            <ul>
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1649, "\"", 1656, 0);
            EndWriteAttribute();
            WriteLiteral(">200, Green block, NewYork</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1732, "\"", 1739, 0);
            EndWriteAttribute();
            WriteLiteral(">+994 50 000 00 00</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1807, "\"", 1814, 0);
            EndWriteAttribute();
            WriteLiteral(@">contact@winter.com</a></li>
                            </ul>

                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 col-sm-12"">
                    <div class=""footer-side"">
                        <div class=""footer-info"">
                            <div class=""footer-logo"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "44cc88ebc50e03087849b81eb9d44831b08ee2538155", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2220, "~/assets/img/navbar/", 2220, 20, true);
#nullable restore
#line 55 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Shared\Components\Footer\Default.cshtml"
AddHtmlAttributeValue("", 2240, Model.Settings["FooterLogo"], 2240, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                <p>
                                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                                    Ipsum has been the industry's.
                                </p>
                            </div>
                            <div class=""social"">
                                <ul>
                                    <div class=""social-icon"">
                                    <li>
                                        <a href=""https://www.facebook.com/"">
                                            ");
#nullable restore
#line 67 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Shared\Components\Footer\Default.cshtml"
                                       Write(Html.Raw(Model.Settings["Facebook"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            
                                        </a>
                                    </li>
                            </div>
                            <div class=""social-icon"">
                                <li>
                                    <a href=""https://twitter.com/i/flow/login"">
                                        ");
#nullable restore
#line 75 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Shared\Components\Footer\Default.cshtml"
                                   Write(Html.Raw(Model.Settings["Tiwitter"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </a>
                                </li>
                            </div>
                            <div class=""social-icon"">
                                <li>
                                    <a href=""https://www.instagram.com/"">
                                        ");
#nullable restore
#line 83 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Shared\Components\Footer\Default.cshtml"
                                   Write(Html.Raw(Model.Settings["Instagram"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </li>
                            </div>
                            </ul>
                        </div>

                    </div>
                </div>
            </div>

            <div class=""line""></div>
            <div class=""copyright"">
                Copyright ??2022 All rights reserved | This site is made with by Sadiq Nahmetov
            </div>
        </div>
        </div>

    </section>
</footer>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FooterVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
