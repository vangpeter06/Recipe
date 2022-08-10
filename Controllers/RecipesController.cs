using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBox.Controllers
{
  public class RecipesController : Controller
  {
    private readonly RecipeBoxContext _db;

    public RecipesController(RecipeBoxContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Recipes.OrderByDescending(model => model.Rating).ToList());
    }

    public ActionResult Create()
    {
      ViewBag.IngredientId = new SelectList(_db.Ingredients, "IngredientId", "Name");
      ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Tag");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Recipe recipe, int IngredientId)
    {
      _db.Recipes.Add(recipe);
      _db.SaveChanges();
      if (IngredientId != 0)
      {
        _db.RecipeIngredient.Add(new RecipeIngredient() { IngredientId = IngredientId, RecipeId = recipe.RecipeId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    // public ActionResult Details(int id)
    // {
    //   var thisRecipe = _db.Recipes
    //       .Include(recipe => recipe.JoinEntities1)
    //       .ThenInclude(join => join.Ingredient)
    //       .FirstOrDefault(recipe => recipe.RecipeId == id);
    //   // var thisCategory = _db.Recipes
    //   //     .Include(recipe => recipe.JoinEntities2)
    //   //     .ThenInclude(join => join.Category)
    //   //     .FirstOrDefault(recipe => recipe.RecipeId == id);
    //   return View(thisRecipe);
    // }

    public ActionResult Edit(int id)
    {
      var thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
      ViewBag.IngredientId = new SelectList(_db.Ingredients, "IngredientId", "Name");
      return View(thisRecipe);
    }

    [HttpPost]
    public ActionResult Edit(Recipe recipe, int IngredientId)
    {
      if (IngredientId != 0)
      {
        _db.RecipeIngredient.Add(new RecipeIngredient() { IngredientId = IngredientId, RecipeId = recipe.RecipeId });
      }
      _db.Entry(recipe).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddIngredient(int id)
    {
      var thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
      ViewBag.IngredientId = new SelectList(_db.Ingredients, "IngredientId", "Name");
      return View(thisRecipe);
    }

    [HttpPost]
    public ActionResult AddIngredient(Recipe recipe, int IngredientId)
    {
      if (IngredientId != 0)
      {
        _db.RecipeIngredient.Add(new RecipeIngredient() { IngredientId = IngredientId, RecipeId = recipe.RecipeId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
      return View(thisRecipe);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
      _db.Recipes.Remove(thisRecipe);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteIngredient(int joinId)
    {
      var joinEntry = _db.RecipeIngredient.FirstOrDefault(entry => entry.RecipeIngredientId == joinId);
      _db.RecipeIngredient.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}