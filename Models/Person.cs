using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace LeThuTrangBTH2.Models;
public class Person
{
    [Key]
    [Required(ErrorMessage ="Không được để trống")]
    public string PersonID { get; set; }
    public string PersonName { get; set; }
}