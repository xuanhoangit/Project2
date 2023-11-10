using Microsoft.AspNetCore.Mvc;
using ShopIvy.Models;
using ShopIvy.Repositories;

namespace ShopIvy.Controllers;
public class CategoryController:Controller
{
    private readonly ICategoryRepo repo;

    public CategoryController(ICategoryRepo repo)
    {
        this.repo = repo;
    }
    public async Task<IActionResult> Index(){
        var listCategory=await repo.Display();
        return View(listCategory); 
    }
    public async Task<IActionResult> Display(){
        var listCategory=await repo.Display();
        return Json(listCategory);
    }
    public IActionResult AddCategory(){
        return View();
    }
    [HttpPost]
    public IActionResult AddCategory(Category category){
        category.Image="category"+category.Title+Libraries.LibraryProject.HandleFileImage(category.File);
        if(ModelState.IsValid){
            category.CreateAt=DateTime.Now;
            category.UpdateAt=category.CreateAt;
            repo.AddCategory(category);
            return RedirectToAction("Index");
        }
        return View();
    }
}