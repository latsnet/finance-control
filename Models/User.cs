using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("Users")]
public class User
{ 

    [Key]
    public int UserId { get; set; }

    [StringLength(200)]
    public string Name { get; set; }

    [StringLength(200)]
    public string UserName { get; set; }

    [StringLength(2000)]
    public string Password { get; set; }

    [Required]
    public Role Role { get; set; }

}