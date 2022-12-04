using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("CreditCardBills")]
public class CreditCardBill
{ 
    
    [Key]
    public int CreditCardBillId { get; set; }

    public DateTime DueDate { get; set; }

    [Required]
    public CreditCard CreditCard { get; set; }

    public List<CreditCardTransaction> Transactions { get; set; }

}