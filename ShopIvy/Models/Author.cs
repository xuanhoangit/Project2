using System.ComponentModel.DataAnnotations;

namespace ShopIvy.Models;
public class Author
{
    public int Id { get; set; }
    [Required(ErrorMessage =" Khong dc de trong")]
    public string? Firstname { get; set; }
    [Required(ErrorMessage =" Khong dc de trong")]
    public string? Lastname { get; set; }
    [Required(ErrorMessage =" Khong dc de trong")]
    public string? Biography { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public int Status { get; set; }=1;
}