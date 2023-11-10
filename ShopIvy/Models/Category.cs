using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopIvy.Models;
public class Category
{
    public int Id { get; set; }
    [Required(ErrorMessage =" Khong dc de trong")]
    public string? Title { get; set; }
    public string? Image { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public int Status { get; set; }=1;
    [NotMapped]
    [Required(ErrorMessage =" Khong dc de trong")]
    public IFormFile? File { get; set; }
}