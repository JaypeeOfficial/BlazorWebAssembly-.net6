using MyBudgetBook.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace MyBudgetBook.Data;

public class Person : BaseEntity
{

    [Required]
    public string? Name { get; set; }

    [Required, EmailAddress]
    public string? Email { get; set; }
}
