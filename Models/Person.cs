using System.ComponentModel.DataAnnotations;

namespace ShiftManagementSystem.Models;

public abstract class Person
{

    
    [Required(ErrorMessage = "Document is required")]
    [MaxLength(10,ErrorMessage ="Document is too long")]
    public string Document { get; set; }
    
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(100,ErrorMessage ="Name is too long")]
    public string FullName { get; set; }
    
    public DateTime? BirthDate { get; set; }
    
}