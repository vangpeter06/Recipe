#pragma checksum "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87a7c9cb3f5ad32c67df40df5efaff4da96e0819"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Edit), @"mvc.1.0.view", @"/Views/Recipes/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87a7c9cb3f5ad32c67df40df5efaff4da96e0819", @"/Views/Recipes/Edit.cshtml")]
    public class Views_Recipes_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this recipe: ");
#nullable restore
#line 9 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.HiddenFor(model => model.RecipeId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.LabelFor(model => model.Instruction));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.TextBoxFor(model => model.Instruction));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.Label("Rating for this recipe (1-5, 5 being the highest)"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.TextBoxFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 25 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 26 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 27 "/Users/petervang/Desktop/Recipe_Box.Solution/RecipeBox/Views/Recipes/Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
