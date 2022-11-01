using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace LeThuTrangBTH2.Models;
public class Student
{
    [Key]
    [Required(ErrorMessage ="Không được để trống")]
    //prop
    public string StudentID { get; set; }
    
    public string StudentName { get; set; }
}