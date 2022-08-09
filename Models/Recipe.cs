using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.Ingredients = new HashSet<Ingredient>();
      // this.Instructions = new HashSet<Instruction>();
    }

    public int RecipeId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Ingredient> Ingredients { get; set; }
  }
}