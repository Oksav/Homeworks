#pragma checksum "C:\Users\vasko\Desktop\MovieStore\MovieStore\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49e51dba6294ab72dae64d210e4808584c9557cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Index.cshtml", typeof(AspNetCore.Views_Movie_Index))]
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
#line 1 "C:\Users\vasko\Desktop\MovieStore\MovieStore\Views\_ViewImports.cshtml"
using MovieStore;

#line default
#line hidden
#line 2 "C:\Users\vasko\Desktop\MovieStore\MovieStore\Views\_ViewImports.cshtml"
using MovieStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49e51dba6294ab72dae64d210e4808584c9557cd", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a8c2dc702b202c6daeaeb5df09bdab9162bf52c", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MovieModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\vasko\Desktop\MovieStore\MovieStore\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(67, 35, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n<div class=\"btn\">");
            EndContext();
            BeginContext(103, 43, false);
#line 7 "C:\Users\vasko\Desktop\MovieStore\MovieStore\Views\Movie\Index.cshtml"
            Write(Html.ActionLink("Add NEW MOVIE !!!", "Add"));

#line default
#line hidden
            EndContext();
            BeginContext(146, 36, true);
            WriteLiteral("</div>\r\n<div class=\"body-content\">\r\n");
            EndContext();
#line 9 "C:\Users\vasko\Desktop\MovieStore\MovieStore\Views\Movie\Index.cshtml"
     foreach (var movie in Model)
    {

#line default
#line hidden
            BeginContext(224, 40, true);
            WriteLiteral("    <div class=\"form-control\">\r\n        ");
            EndContext();
            BeginContext(265, 15, false);
#line 12 "C:\Users\vasko\Desktop\MovieStore\MovieStore\Views\Movie\Index.cshtml"
   Write(movie.MovieName);

#line default
#line hidden
            EndContext();
            BeginContext(280, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(283, 64, false);
#line 12 "C:\Users\vasko\Desktop\MovieStore\MovieStore\Views\Movie\Index.cshtml"
                     Write(Html.ActionLink("Details", "MovieDetails", new {id = movie.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(347, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(360, 51, false);
#line 13 "C:\Users\vasko\Desktop\MovieStore\MovieStore\Views\Movie\Index.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new {id=movie.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(411, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(424, 55, false);
#line 14 "C:\Users\vasko\Desktop\MovieStore\MovieStore\Views\Movie\Index.cshtml"
   Write(Html.ActionLink("Delete", "Delete", new {id=movie.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(479, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 16 "C:\Users\vasko\Desktop\MovieStore\MovieStore\Views\Movie\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(500, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MovieModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
