using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("CreditCardTransactions")]
public class CreditCardTransaction
{ 

    [Key]
    public int CreditCardTransactionId { get; set; }

    [Required]
    public Transaction Transaction { get; set; }

}