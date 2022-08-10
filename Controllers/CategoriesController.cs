using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBox.Controllers
{
  public class CategoriesController : Controller
  {
    private readonly RecipeBoxContext _db;

    public CategoriesController(RecipeBoxContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Categories.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.RecipeId = new SelectList(_db.Recipes, "RecipeId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Category category, int RecipeId)
    {
      _db.Categories.Add(category);
      _db.SaveChanges();
      if (RecipeId != 0)
      {
        _db.CategoryRecipe.Add(new CategoryRecipe() { RecipeId = RecipeId, CategoryId = category.CategoryId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisCategory = _db.Categories
          .Include(category => category.JoinEntities)
          .ThenInclude(join => join.Recipe)
          .FirstOrDefault(category => category.CategoryId == id);
      return View(thisCategory);
    }
    public ActionResult Edit(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      ViewBag.RecipeId = new SelectList(_db.Recipes, "RecipeId", "Name");
      return View(thisCategory);
    }

    [HttpPost]
    public ActionResult Edit(Category category, int RecipeId)
    {
      if (RecipeId != 0)
      {
        _db.CategoryRecipe.Add(new CategoryRecipe() { RecipeId = RecipeId, CategoryId = category.CategoryId });
      }
      _db.Entry(category).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

       public ActionResult AddRecipe(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      ViewBag.RecipeId = new SelectList(_db.Recipes, "RecipeId", "Name");
      return View(thisCategory);
    }

    [HttpPost]
    public ActionResult AddRecipe(Category category, int RecipeId)
    {
      if (RecipeId != 0)
      {
        _db.CategoryRecipe.Add(new CategoryRecipe() { RecipeId = RecipeId, CategoryId = category.CategoryId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      return View(thisCategory);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      _db.Categories.Remove(thisCategory);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteRecipe(int joinId)
    {
      var joinEntry = _db.CategoryRecipe.FirstOrDefault(entry => entry.CategoryRecipeId == joinId);
      _db.CategoryRecipe.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}