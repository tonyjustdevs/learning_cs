
using System.ComponentModel.DataAnnotations;

namespace Northwind.EntityModels;

public class Question
{
    public int QuestionId { get; set; } // The primary key.
    [Required]
    [StringLength(40)]
    public string QuestionDescription { get; set; } = null!;
    [Required]
    [StringLength(40)]
    public string Answer{ get; set; } = null!;
    // add reference to category
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;

}
