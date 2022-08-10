namespace RecipeBox.Models
{
  public class RecipeIngredient
  {       
    public int RecipeId { get; set; }
    public int IngredientId { get; set; }
    public int RecipeIngredientId {get; set;}
    public virtual Ingredient Ingredient { get; set; }
    public virtual Recipe Recipe { get; set; }
  }
}