using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Ingredient
  {
    public Ingredient()
    {
      this.JoinEntities = new HashSet<RecipeIngredient>();
    }

    public int IngredientId { get; set; }
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; } 

    public virtual ICollection<RecipeIngredient> JoinEntities { get; set; }
  }
}