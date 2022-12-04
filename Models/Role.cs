using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("Roles")]
public class Role
{ 

    [Key]
    public int RoleId { get; set; }

    [StringLength(100)]
    public string RoleName { get; set; }

}