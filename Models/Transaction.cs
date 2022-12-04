using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("Transactions")]
public class Transaction
{

    [Key]
    public int TransactionId { get; set; }

    [Required]
    public Category Category { get; set; }

    [Required]
    public DateTime DueDate { get; set; }

    [Required]
    public OperationType Type { get; set; }
    
    [Required]
    public Decimal Value { get; set; }

    [Required]
    [StringLength(200)]
    public string Description { get; set; }

    [StringLength(4000)]
    public string Observations { get; set; }

    public List<Tag> Tags { get; set; }
    
    public List<TransactionAttachment> Attachments { get; set; }

}