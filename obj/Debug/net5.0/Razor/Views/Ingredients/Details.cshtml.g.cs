#pragma checksum "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92c549395a64077e6f450affbb25301453eda0b4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92c549395a64077e6f450affbb25301453eda0b4", @"/Views/Ingredients/Details.cshtml")]
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
            WriteLiteral("<h3>\n<p>");
#nullable restore
#line 10 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
Write(Html.ActionLink("Edit Ingredient", "Edit", new { id = Model.IngredientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 11 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
Write(Html.ActionLink("Delete Ingredient", "Delete", new { id = Model.IngredientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 12 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 13 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Ingredient> Html { get; private set; }
    }
}
#pragma warning restore 1591
