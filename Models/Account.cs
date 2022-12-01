using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("Accounts")]
public class Account
{

    [Key]
    public int AccountId { get; set; }

    public Bank Bank { get; set; }

}