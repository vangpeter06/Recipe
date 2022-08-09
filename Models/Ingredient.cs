namespace RecipeBox.Models
{
  public class Ingredient
  {
    public int IngredientId { get; set; }
    public string Name { get; set; }
    public int RecipeId { get; set; }
    public virtual Recipe Recipe { get; set; }
  }
}