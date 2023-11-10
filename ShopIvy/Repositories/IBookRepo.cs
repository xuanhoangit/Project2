using ShopIvy.Models;
using ShopIvy.ModelsBook;

namespace ShopIvy.Repositories;
public interface IBookRepo{
    Task<bool> AddBook(AddBook book);
} 