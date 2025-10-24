using System.ComponentModel.DataAnnotations;
using SaludLinux.Models;
using ShiftManagementSystem.Models;

namespace ShiftManagementSystem.Data.Entities;

public class Affiliate:Person
{
    [Key]
    public int IdAff {get; set;}
    
    [MaxLength(10,ErrorMessage ="The phone number is too long")]
    public string PhoneNumber { get; set; }
    
    [MaxLength(100,ErrorMessage ="The email is too long")]
    public string Email {get; set;}
    
    [MaxLength(150,ErrorMessage ="Your address is too long")]
    public string Address { get; set; }
    
    public virtual Card? Card { get; set; }
    public virtual ICollection<Ticket> Employees { get; set; }
}