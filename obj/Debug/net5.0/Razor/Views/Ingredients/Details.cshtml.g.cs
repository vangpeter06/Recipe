#pragma checksum "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c534ad20c61e9afab01fe59219e8aec576cad7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredients_Details), @"mvc.1.0.view", @"/Views/Ingredients/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c534ad20c61e9afab01fe59219e8aec576cad7c", @"/Views/Ingredients/Details.cshtml")]
    public class Views_Ingredients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Ingredient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Ingredient Details</h2>\n<hr />\n<h3>");
#nullable restore
#line 9 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n");
#nullable restore
#line 11 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This ingredient does not belong to any recipes</p>\n");
#nullable restore
#line 14 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Recipes the ingredient belongs to:</h4>\n  <ul>\n");
#nullable restore
#line 19 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 21 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
   Write(join.Recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 22 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
     using (Html.BeginForm("DeleteRecipe", "Ingredient"))
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
 Write(Html.Hidden("joinId", @join.RecipeIngredientId));

#line default
#line hidden
#nullable disable
            WriteLiteral("      <input type=\"submit\" value=\"Delete\"/>\n");
#nullable restore
#line 26 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
     
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 29 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 30 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
Write(Html.ActionLink("Add a Recipe", "AddRecipe", new { id = Model.IngredientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<p>");
#nullable restore
#line 32 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
Write(Html.ActionLink("Back to ingredients", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 33 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
Write(Html.ActionLink("Edit Ingredient", "Edit", new { id = Model.IngredientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 34 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
Write(Html.ActionLink("Delete Ingredient", "Delete", new { id = Model.IngredientId }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Ingredient> Html { get; private set; }
    }
}
#pragma warning restore 1591
