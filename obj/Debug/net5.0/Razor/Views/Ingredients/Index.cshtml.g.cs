#pragma checksum "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Ingredients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9dbfd10171225c235013b543c5e1708c74f0729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredients_Index), @"mvc.1.0.view", @"/Views/Ingredients/Index.cshtml")]
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
#line 5 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Ingredients/Index.cshtml"
using RecipeBox.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9dbfd10171225c235013b543c5e1708c74f0729", @"/Views/Ingredients/Index.cshtml")]
    public class Views_Ingredients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RecipeBox.Models.Ingredient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Ingredients/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Ingredients for ");
#nullable restore
#line 8 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Ingredients/Index.cshtml"
               Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
#nullable restore
#line 10 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Ingredients/Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <ul>\n");
#nullable restore
#line 13 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Ingredients/Index.cshtml"
     foreach (Ingredient ingredient in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>");
#nullable restore
#line 15 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Ingredients/Index.cshtml"
     Write(Html.ActionLink($"{ingredient.Name}", "Details", new { id = ingredient.IngredientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 16 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Ingredients/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 18 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Ingredients/Index.cshtml"
} 
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No Ingredients have been added yet!</h3>\n");
#nullable restore
#line 22 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Ingredients/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 24 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Ingredients/Index.cshtml"
Write(Html.ActionLink("Add new ingredient", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 25 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Ingredients/Index.cshtml"
Write(Html.ActionLink("Back to Home", "Index", "Home"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RecipeBox.Models.Ingredient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
