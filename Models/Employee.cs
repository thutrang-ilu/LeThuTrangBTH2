using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace LeThuTrangBTH2.Models;
public class Employee
{
    [Key]
    [Required(ErrorMessage ="Không được để trống")]
    public string EmployeeID {get; set;}
    public string EmployeeName {get; set; }
}