using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopIvy.Models;
public class Book
{   
    public int Id { get; set; }
    [Required(ErrorMessage =" Khong dc de trong")]
    public string? Title { get; set; }
    [Required(ErrorMessage =" Khong dc de trong")]
    public float Price { get; set; }
    [Required(ErrorMessage =" Khong dc de trong")]
    public int Quantity { get; set; }
    [Required(ErrorMessage =" Khong dc de trong")]
    public string? Isbn { get; set; }
    [Required(ErrorMessage =" Khong dc de trong")]
    public string? Sku { get; set; }
    public string? Cover { get; set; }
    [Required(ErrorMessage =" Khong dc de trong")]
    public string? Description { get; set; }
    public DateTime CreateAt  { get; set; }
    public DateTime UpdateAt  { get; set; }
    public int Status { get; set; }=1;
    public int AuthorId { get; set; }
    public Author? author{ get; set;}
    public int PublisherId { get; set; }
    public Publisher? publisher{ get; set;}
    public int CategoryId { get; set; }
    public Category? category{ get; set;}
    [NotMapped]
    public IFormFile Image { get; set; }
}