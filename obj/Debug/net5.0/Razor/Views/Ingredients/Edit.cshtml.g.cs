#pragma checksum "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43e04565b0a540c468ca651e5ffb971726d13ddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredients_Edit), @"mvc.1.0.view", @"/Views/Ingredients/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e04565b0a540c468ca651e5ffb971726d13ddf", @"/Views/Ingredients/Edit.cshtml")]
    public class Views_Ingredients_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Ingredient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this ingredient: ");
#nullable restore
#line 9 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Edit.cshtml"
                     Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Edit.cshtml"
Write(Html.HiddenFor(model => model.IngredientId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Edit.cshtml"
Write(Html.Label("Select recipe"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Edit.cshtml"
Write(Html.DropDownList("RecipeId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 22 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 24 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 25 "/Users/petervang/Desktop/RecipeBox.Solution/RecipeBox/Views/Ingredients/Edit.cshtml"
Write(Html.ActionLink("Back to Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n\n");
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
