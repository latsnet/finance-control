using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_control.Models;

[Table("TransactionAttachments")]
public class TransactionAttachment
{ 
    [Key]
    public int TransactionAttachmentId { get; set; }

    [StringLength(100)]
    public string Identification { get; set; }

    [StringLength(255)]
    public string FileName { get; set; }

}