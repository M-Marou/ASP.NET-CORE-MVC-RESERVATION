#pragma checksum "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4488f8fd062562bb8f4c843214e2e57d2ebe83d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_MyReservations), @"mvc.1.0.view", @"/Views/Reservation/MyReservations.cshtml")]
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
#line 1 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\_ViewImports.cshtml"
using YCReservations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\_ViewImports.cshtml"
using YCReservations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4488f8fd062562bb8f4c843214e2e57d2ebe83d2", @"/Views/Reservation/MyReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea929784c3189be693e7d11ebfac85f2b2d25c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_MyReservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reservations>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
  
    int counter = 1;
    ViewBag.Title = "List of reservations";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""my-5 text-left"">
    <h2> List of Reservations </h2>
    <hr />
</div>

<div class=""my-5"">
    <table id=""myTable"" class=""table"">
        <thead class=""thead-dark table-hover table-dark"">
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">");
#nullable restore
#line 18 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                           Write(Html.DisplayNameFor(item => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 19 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                           Write(Html.DisplayNameFor(item => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 20 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                           Write(Html.DisplayNameFor(item => item.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">Actions</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
             foreach (Reservations reservation in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                   Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                   Write(reservation.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 30 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                     if (reservation.Status == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-muted\">Pending</td>\r\n");
#nullable restore
#line 33 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                    } else if (reservation.Status == true) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-success\">Approved</td>\r\n");
#nullable restore
#line 35 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                    } else 
                    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-danger\">Rejected</td>\r\n");
#nullable restore
#line 38 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 39 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                   Write(reservation.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"width: 200px;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4488f8fd062562bb8f4c843214e2e57d2ebe83d29560", async() => {
                WriteLiteral(@"
                            <button class=""btn btn-success btn-sm"">Approve</button>
                            <button class=""btn btn-danger btn-sm"">Reject</button>
                            <button type=""submit"" class=""btn btn-secondary btn-sm"" onclick=""return confirm('Are you sure would you like to delete this reservation!')"">Delete</button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 48 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                counter++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <div class=\"my-5 text-center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4488f8fd062562bb8f4c843214e2e57d2ebe83d211799", async() => {
                WriteLiteral("Make new reservation");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4488f8fd062562bb8f4c843214e2e57d2ebe83d213185", async() => {
                WriteLiteral("Back to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("DTReservationsList", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#myTable\').dataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reservations>> Html { get; private set; }
    }
}
#pragma warning restore 1591
