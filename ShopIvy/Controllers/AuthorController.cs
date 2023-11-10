using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using ShopIvy.Models;
using ShopIvy.Repositories;

namespace ShopIvy.Controllers;
public class AuthorController:Controller
{
    private readonly IAuthorRepo repo;

    public AuthorController(IAuthorRepo repo)
    {
        this.repo = repo;
    }
    public async Task<IActionResult> Index(){
        var listAuthor= await repo.Display();
        return View(listAuthor);
    }
    public async Task<IActionResult> Display(){
        var listAuthor= await repo.Display();
        return Json(listAuthor);
    }
    public IActionResult AddAuthor(){
        return View();
    }
    [HttpPost]
    public IActionResult AddAuthor(Author author){
        if(ModelState.IsValid){
            author.CreateAt=DateTime.Now;
            author.UpdateAt=author.CreateAt;
            repo.AddAuthor(author);
            return RedirectToAction("Index");
        }
        return View();
    }
}