using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RecipeBox.Models
{
  public class RecipeBoxContext : DbContext
  {
    public DbSet<Ingredient> Ingredients { get; set; }
    // public DbSet<Instruction> Instructions { get; set; }
    public DbSet<Recipe> Recipes { get; set; }

    public RecipeBoxContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}