#pragma checksum "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bedac1c383a3315bc0d7bd16e9104d1677924565"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DueRentals_Details), @"mvc.1.0.view", @"/Views/DueRentals/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bedac1c383a3315bc0d7bd16e9104d1677924565", @"/Views/DueRentals/Details.cshtml")]
    public class Views_DueRentals_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Centrumbiblioteket.Models.Rental>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Rental</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Inventory.InventoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RentalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml"
       Write(Html.DisplayFor(model => model.RentalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rented));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rented));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.CustomerFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1311, "\"", 1341, 1);
#nullable restore
#line 46 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Details.cshtml"
WriteAttributeValue("", 1326, Model.RentalId, 1326, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Centrumbiblioteket.Models.Rental> Html { get; private set; }
    }
}
#pragma warning restore 1591
