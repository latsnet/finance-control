using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("AccountTransactions")]
public class AccountTransaction
{

    [Key]
    public int AccountTransactionId { get; set; }

    [Required]
    public Account Account { get; set; }

    [Required]
    public Transaction Transaction { get; set; }

}