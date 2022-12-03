using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("CreditCardBrands")]
public class CreditCardBrand
{

    [Key]
    public int CreditCardBrandId { get; set; }

    [StringLength(100)]
    public string BrandName { get; set; }

}