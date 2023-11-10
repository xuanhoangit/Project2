using Microsoft.EntityFrameworkCore;
using ShopIvy.Data;
using ShopIvy.Models;

namespace ShopIvy.Repositories;
public class AuthorRepo:IAuthorRepo
{
    private readonly ApplicationDbContext db;

    public AuthorRepo(ApplicationDbContext db)
    {
        this.db = db;
    }
    public async Task<List<Author>> Display(){
        var listAuthor=await db.Authors.ToListAsync();
        return listAuthor;
    } 
    public bool AddAuthor(Author author){
        db.Authors.Add(author);
        db.SaveChanges();
        return true;
    }
}