#pragma checksum "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Categories/AddRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be847b250cdb49447aca2a3db758f646667df1ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_AddRecipe), @"mvc.1.0.view", @"/Views/Categories/AddRecipe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be847b250cdb49447aca2a3db758f646667df1ef", @"/Views/Categories/AddRecipe.cshtml")]
    public class Views_Categories_AddRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Categories/AddRecipe.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Add a recipe</h2>\n\n<h4>Add a recipe to this category: ");
#nullable restore
#line 9 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Categories/AddRecipe.cshtml"
                              Write(Html.DisplayFor(model => model.Tag));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Categories/AddRecipe.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Categories/AddRecipe.cshtml"
Write(Html.HiddenFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Categories/AddRecipe.cshtml"
Write(Html.Label("Select Recipe"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Categories/AddRecipe.cshtml"
Write(Html.DropDownList("RecipeId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 19 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Categories/AddRecipe.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 21 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Categories/AddRecipe.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
