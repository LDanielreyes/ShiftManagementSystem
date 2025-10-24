using System.ComponentModel.DataAnnotations;
using SaludLinux.Models;
using ShiftManagementSystem.Models;

namespace ShiftManagementSystem.Data.Entities;

public class Employee:Person
{
    [Key]
    public int IdEmp {get; set;}
    
    [Required(ErrorMessage = "Password is required")] 
    [MaxLength(50,ErrorMessage ="Password is too long")]
    public string Password {get; set;}
    
    public virtual ICollection<TicketRegister>? TicketRegisters { get; set; }
    public virtual ICollection<Ticket>? Tickets { get; set; }
    public virtual ICollection<ServiceHistory>? ServiceHistories { get; set; }
}