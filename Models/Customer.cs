using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace LeThuTrangBTH2.Models;
public class Customer
{
    [Key]
    [Required(ErrorMessage ="Không được để trống")]
    public string CustomerID {get; set; }
    public string CustomerName {get; set; }
}