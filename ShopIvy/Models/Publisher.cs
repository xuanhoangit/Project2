using System.ComponentModel.DataAnnotations;

namespace ShopIvy.Models;
public class Publisher
{
    public int Id { get; set; }
    [Required(ErrorMessage =" Khong dc de trong")]
    public string? Name { get; set; }
    [Required(ErrorMessage =" Khong dc de trong")]
    public string? Hotline { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public int Status { get; set; }=1;
}