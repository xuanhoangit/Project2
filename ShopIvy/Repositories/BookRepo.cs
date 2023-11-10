using ShopIvy.Data;
using ShopIvy.Models;
using ShopIvy.ModelsBook;

namespace ShopIvy.Repositories;
public class BookRepo:IBookRepo
{
    private readonly ApplicationDbContext db;

    public BookRepo(ApplicationDbContext db)
    {
        this.db = db;
    }
    public async Task<bool> AddBook(AddBook book){
        using (var transaction = await db.Database.BeginTransactionAsync())
        {
        try
        {
            if(book.Author is not null){
                book.Author.CreateAt=DateTime.Now;
                book.Author.UpdateAt=book.Author.CreateAt;
                db.Authors.Add(book.Author);
                book.Book.AuthorId=book.Author.Id;
            }
            if(book.Publisher is not null){
                book.Publisher.CreateAt=DateTime.Now;
                book.Publisher.UpdateAt=book.Publisher.CreateAt;
                db.publisher.Add(book.Publisher);
                book.Book.AuthorId=book.Publisher.Id;
            }
            if(book.Category is not null){
                book.Category.CreateAt=DateTime.Now;
                book.Category.UpdateAt=book.Category.CreateAt;
                db.Categories.Add(book.Category);
                book.Book.AuthorId=book.Category.Id;
            }
            book.Book.CreateAt=DateTime.Now;
            book.Book.UpdateAt=book.Book.CreateAt;
            db.Books.Add(book.Book);
            await db.SaveChangesAsync();
            await transaction.CommitAsync();
        }
        catch (System.Exception)
        {
             await transaction.RollbackAsync();
                return false;
        }  
        
        }
        
        return true;
    }
}