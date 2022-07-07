#pragma checksum "C:\Users\Acer\source\repos\layihe\layihe\Views\Report\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4002ef2a6776d42c919ab1cdeb56526d165e72c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_Index), @"mvc.1.0.view", @"/Views/Report/Index.cshtml")]
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
#line 1 "C:\Users\Acer\source\repos\layihe\layihe\Views\_ViewImports.cshtml"
using layihe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\source\repos\layihe\layihe\Views\_ViewImports.cshtml"
using layihe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\source\repos\layihe\layihe\Views\Report\Index.cshtml"
using layihe.Dtos.FlightDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4002ef2a6776d42c919ab1cdeb56526d165e72c5", @"/Views/Report/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f2b7129842f3c77aee3c8b46b0069731f57df8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FlightToListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Acer\source\repos\layihe\layihe\Views\Report\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .report {
        position: relative !important;
        background-image: url(""../reportbackground.jpg"");
        width: 100% !important;
        height: 100% !important;
        position: relative;
        padding-top:40px;
        background-size: cover;
        background-position: center;
    }
    .reprotIndex {
        margin-left: 170px !important;
    }

        .reprotIndex .table {
            background-color: whitesmoke;
            color: darkblue;
            text-align: center;
        }

        .reprotIndex .btn {
            float: right !important;
            margin: 15px 0 15px 15px;
        }

    .table {
        --bs-table-striped-bg: lavender;
        --bs-table-striped-color: dodgerblue;
    }
</style>
<div class=""report"">


    <div style=""position:absolute"" class=""reprotIndex"">
        <table class=""table table-bordered "">
            <thead>
                <tr>
                    <th>From</th>
                    <th>To</th>
 ");
            WriteLiteral(@"                   <th>Departure Time</th>
                    <th>Arrivial Time</th>
                    <th>Capacity</th>
                    <th>Seating Capacity</th>
                    <th>Price</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 56 "C:\Users\Acer\source\repos\layihe\layihe\Views\Report\Index.cshtml"
                 foreach (var f in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 59 "C:\Users\Acer\source\repos\layihe\layihe\Views\Report\Index.cshtml"
                       Write(f.DepartureCity.DepName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 60 "C:\Users\Acer\source\repos\layihe\layihe\Views\Report\Index.cshtml"
                       Write(f.ArrivialCity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 61 "C:\Users\Acer\source\repos\layihe\layihe\Views\Report\Index.cshtml"
                       Write(f.DepartureTime.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 62 "C:\Users\Acer\source\repos\layihe\layihe\Views\Report\Index.cshtml"
                       Write(f.ArrivialTime.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 63 "C:\Users\Acer\source\repos\layihe\layihe\Views\Report\Index.cshtml"
                       Write(f.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 64 "C:\Users\Acer\source\repos\layihe\layihe\Views\Report\Index.cshtml"
                       Write(f.SeatingCapacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 65 "C:\Users\Acer\source\repos\layihe\layihe\Views\Report\Index.cshtml"
                       Write(f.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 67 "C:\Users\Acer\source\repos\layihe\layihe\Views\Report\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FlightToListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
