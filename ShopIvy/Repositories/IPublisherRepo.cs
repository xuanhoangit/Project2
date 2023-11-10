using ShopIvy.Models;

namespace ShopIvy.Repositories;
public interface IPublisherRepo
{
    bool AddPublisher(Publisher publisher);
    Task<List<Publisher>> Display();
}