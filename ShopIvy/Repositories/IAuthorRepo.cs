using ShopIvy.Models;

namespace ShopIvy.Repositories;
public interface IAuthorRepo
{
    public bool AddAuthor(Author author);
    Task<List<Author>> Display();
}