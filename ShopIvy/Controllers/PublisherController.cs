using Microsoft.AspNetCore.Mvc;
using ShopIvy.Models;
using ShopIvy.Repositories;

namespace ShopIvy.Controllers;
public class PublisherController:Controller
{
    private readonly IPublisherRepo repo;

    public PublisherController(IPublisherRepo repo)
    {
        this.repo = repo;
    }
    public async Task<IActionResult> Index(){
        var listPublisher= await repo.Display();
        return View(listPublisher);
    }
    public async Task<IActionResult> Display(){
        var listPublisher= await repo.Display();
        return Json(listPublisher);
    }
    public IActionResult AddPublisher(){
        return View();
    }
    [HttpPost]
    public IActionResult AddPublisher(Publisher publisher){
        publisher.CreateAt=DateTime.Now;
        publisher.UpdateAt=publisher.CreateAt;
        if(ModelState.IsValid){
            repo.AddPublisher(publisher);
            return RedirectToAction("Index");
        }
        return View();
    }
}