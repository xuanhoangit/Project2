using ShopIvy.Models;

namespace ShopIvy.Repositories;
public interface ICategoryRepo
{
    bool AddCategory(Category category);
    Task<List<Category>> Display();
}