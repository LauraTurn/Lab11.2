#pragma checksum "C:\Users\LTurner3\OneDrive - KNEX\Desktop\11.2CoffeeRegistration2\11.2CoffeeRegistration2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "894d23aaf4cfef486ff3234793d3310719b54a0f"
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
#line 1 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\11.2CoffeeRegistration2\11.2CoffeeRegistration2\Views\_ViewImports.cshtml"
using _11._2CoffeeRegistration2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\11.2CoffeeRegistration2\11.2CoffeeRegistration2\Views\_ViewImports.cshtml"
using _11._2CoffeeRegistration2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"894d23aaf4cfef486ff3234793d3310719b54a0f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d65b07a8a6f39e769a74a57e2021c7114e851711", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\11.2CoffeeRegistration2\11.2CoffeeRegistration2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    a {
        color: blue;
        font-weight: bold;
        font-family: 'Times'
    }
</style>


<div class=""text-center"">
    <h1> Welcome to Hot Grounds</h1>
</div>

<br />
<img src=""/images/Coffee.jpg""
     width=""600""
     height=""500"" />
<br />
<br />
<br />

");
#nullable restore
#line 27 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\11.2CoffeeRegistration2\11.2CoffeeRegistration2\Views\Home\Index.cshtml"
Write(Html.ActionLink("Click here to register!", "showform"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
