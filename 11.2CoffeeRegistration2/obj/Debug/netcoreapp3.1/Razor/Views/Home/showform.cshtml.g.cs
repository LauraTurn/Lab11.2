#pragma checksum "C:\Users\LTurner3\OneDrive - KNEX\Desktop\11.2CoffeeRegistration2\11.2CoffeeRegistration2\Views\Home\showform.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de7ec9c3cdd6bfe75ee9c4ae706c7e2b22966e6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_showform), @"mvc.1.0.view", @"/Views/Home/showform.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de7ec9c3cdd6bfe75ee9c4ae706c7e2b22966e6d", @"/Views/Home/showform.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d65b07a8a6f39e769a74a57e2021c7114e851711", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_showform : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/userresponse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\11.2CoffeeRegistration2\11.2CoffeeRegistration2\Views\Home\showform.cshtml"
  
    ViewData["Title"] = "showform";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>REGISTRATION FORM</h1>\r\n\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de7ec9c3cdd6bfe75ee9c4ae706c7e2b22966e6d4358", async() => {
                WriteLiteral(@"

        <TABLE BORDER=""1"">
            <TR>
                <TD>First Name:</TD>
                <TD>
                    <INPUT TYPE=""TEXT"" NAME=""firstname"" SIZE=""25"">
                </TD>
            </TR>
            <TR>
                <TD>Last Name:</TD>
                <TD><INPUT TYPE=""TEXT"" NAME=""lastname"" SIZE=""25""></TD>
            </TR>
            <TR>
                <TD><label for=""phonenumber"">Phone Number:</label></TD>
                <TD><INPUT TYPE=""tel"" placeholder=""123-444-5555"" id=""phonenumber"" pattern=""[0-9]{3}-[0-9]{3}-[0-9]{4}"" SIZE=""25""></TD>
            </TR>
            <TR>
                <TD><label for=""email"">Email Address:</label></TD>
                <TD><INPUT TYPE=""email"" placeholder=""eg Sparty@msu.edu"" id=""email"" pattern="".+&#64.+&#46.+"" SIZE=""25""></TD>
            </TR>
            <TR>
                <TD>Password:</TD>
                <TD><INPUT TYPE=""password"" placeholder=""Password"" id=""password"" SIZE=""25"" required></TD>
            </TR>
   ");
                WriteLiteral(@"         <TR>
                <TD>Confirm Password:</TD>
                <TD><INPUT TYPE=""password"" placeholder=""Retype Password"" id=""confirmpassword"" SIZE=""25"" required></TD>
            </TR>
        </TABLE>
        <!--<small>Phone Format: 123-456-7890</small> -->


        <br /><br />
        <p>Please select your age:</p>
        <input type=""radio"" id=""age1"" name=""age"" value=""17"">
        <label for=""age1"">0 - 17</label>
        <br />
        <input type=""radio"" id=""age2"" name=""age"" value=""39"">
        <label for=""age2"">18 - 39</label>
        <br />
        <input type=""radio"" id=""age3"" name=""age"" value=""49"">
        <label for=""age3"">40 - 49</label>
        <br />
        <input type=""radio"" id=""age4"" name=""age"" value=""100"">
        <label for=""age3"">50 - 100</label>
        <br />
        <input type=""radio"" id=""age4"" name=""age"" value=""101"">
        <label for=""age3"">Mind your business!</label>
        <br />
        <br />

        <br />
        <P><INPUT TYPE=""SUBMIT");
                WriteLiteral("\" VALUE=\"Submit\" NAME=\"B1\"></P><br />\r\n        <input type=\"reset\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>


<!-- <div id=""message"">
    <h3>Password must contain the following:</h3>
    <p id=""letter"" class=""invalid"">A <b>lowercase</b> letter</p>
    <p id=""capital"" class=""invalid"">A <b>capital (uppercase)</b> letter</p>
    <p id=""number"" class=""invalid"">A <b>number</b></p>
    <p id=""length"" class=""invalid"">Minimum <b>8 characters</b></p>
</div>
    -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
