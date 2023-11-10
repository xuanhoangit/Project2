using Microsoft.EntityFrameworkCore;
using ShopIvy.Data;
using ShopIvy.Models;

namespace ShopIvy.Repositories;
public class PublisherRepo : IPublisherRepo
{
    private readonly ApplicationDbContext db;

    public PublisherRepo(ApplicationDbContext db)
    {
        this.db = db;
    }
    public bool AddPublisher(Publisher publisher)
    {  
        db.publisher.Add(publisher);
        db.SaveChanges();
        return true;
    }

    public async Task<List<Publisher>> Display()
    {
       var listPublisher=await db.publisher.ToListAsync();
       return listPublisher;
    }
}