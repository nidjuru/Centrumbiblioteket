#pragma checksum "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f520ac4047b66e13da51176b13293b8e67004cf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DueRentals_Delete), @"mvc.1.0.view", @"/Views/DueRentals/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f520ac4047b66e13da51176b13293b8e67004cf6", @"/Views/DueRentals/Delete.cshtml")]
    public class Views_DueRentals_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Centrumbiblioteket.Models.Rental>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Rental</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventory.InventoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RentalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RentalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Rented));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Rented));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Nikola\source\repos\Centrumbiblioteket\Centrumbiblioteket\centrumbiblioteket\Views\DueRentals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.CustomerFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd class>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""RentalId"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Centrumbiblioteket.Models.Rental> Html { get; private set; }
    }
}
#pragma warning restore 1591
