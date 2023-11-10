using ShopIvy.Models;

namespace ShopIvy.ModelsBook;
public class AddBook
{
    public Book Book { get; set; }
    public Author? Author { get; set; }
    public Publisher? Publisher { get; set; }
    public Category? Category { get; set; }
}