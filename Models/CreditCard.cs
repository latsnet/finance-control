using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("CreditCards")]
public class CreditCard
{

    [Key]
    public int CreditCardId { get; set; }

    [StringLength(100)]
    public string CreditCardName { get; set; }

    public int CloseDay { get; set; }

    public int DueDate { get; set; }

    public decimal Limit { get; set; }

    public CreditCardBrand Brand { get; set; }

}