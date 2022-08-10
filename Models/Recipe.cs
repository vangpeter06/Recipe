using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.JoinEntities1 = new HashSet<RecipeIngredient>();
      this.JoinEntities2 = new HashSet<CategoryRecipe>();
    }

    public int RecipeId { get; set; }
    public string Name { get; set; }
    public int Rating {get; set;}
    public string Instruction { get; set; }
    public virtual ICollection<RecipeIngredient> JoinEntities1 { get; set; }
    public virtual ICollection<CategoryRecipe> JoinEntities2 { get; set; }
  }
}