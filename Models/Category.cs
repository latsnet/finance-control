using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("Categories")]
public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [StringLength(100, ErrorMessage = "Max length is 100 characters")]
    [Required(ErrorMessage = "Please inform the Category Name")]
    [Display(Name = "Name")]
    public string CategoryName { get; set; }

    [StringLength(200, ErrorMessage = "Max length is 200 characters")]
    [Required(ErrorMessage = "Please inform the description")]
    [Display(Name = "Description")]
    public string Description { get; set; }
    
}
