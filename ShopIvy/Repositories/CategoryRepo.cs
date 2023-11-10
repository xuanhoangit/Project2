using Microsoft.EntityFrameworkCore;
using ShopIvy.Data;
using ShopIvy.Models;

namespace ShopIvy.Repositories;
public class CategoryRepo : ICategoryRepo
{
    private readonly ApplicationDbContext db;

    public CategoryRepo(ApplicationDbContext db)
    {
        this.db = db;
    }
    public bool AddCategory(Category category)
    {   
        db.Categories.Add(category);
        db.SaveChanges();
        return true;
    }

    public async Task<List<Category>> Display()
    {
        var listCategory=await db.Categories.ToListAsync();
        return listCategory;
    }
}