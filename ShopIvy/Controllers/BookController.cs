using Microsoft.AspNetCore.Mvc;
using ShopIvy.Models;
using ShopIvy.ModelsBook;
using ShopIvy.Repositories;

namespace ShopIvy.Controllers;
public class BookController: Controller
{
    private readonly IBookRepo bookRepo;

    public BookController(IBookRepo bookRepo)
    {
        this.bookRepo = bookRepo;
    }
    public IActionResult Index(){
        return View();
    }
    public IActionResult AddBook(){
        var addBook = new AddBook
        {
            // You might initialize default values for Book, Author, Publisher, Category here
            Book = new Book(),
            Author = new Author(),
            Publisher = new Publisher(),
            Category = new Category()
        };
        return View(addBook);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddBook(AddBook book){
        // book.Book.Cover="book"+book.Book.Title+Libraries.LibraryProject.HandleFileImage(book.Book.Image);
        // book.Category.Image="category"+book.Category.Title+Libraries.LibraryProject.HandleFileImage(book.Category.File);
        // if(ModelState.IsValid){
        //     var addbook=await bookRepo.AddBook(book);
        //     if(addbook){
        //         return RedirectToAction("Index");
        //     }
        // }
        return View(book);
    }
}