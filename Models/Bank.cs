using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("Accounts")]
public class Bank
{

    [Key]
    public int AccountId { get; set; }

    [StringLength(3)]
    public string BankCode { get; set; }

    [StringLength(200)]
    public string BankName { get; set; }

}