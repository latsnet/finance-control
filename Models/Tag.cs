using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("Tags")]
public class Tag
{ 

    [Key]
    public int TagId { get; set; }

    [StringLength(100)]
    public string Description { get; set; }
    
}