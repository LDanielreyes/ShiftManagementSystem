using System.ComponentModel.DataAnnotations;
using SaludLinux.Models;

namespace ShiftManagementSystem.Data.Entities;

public class Admin
{
    [Key]
    public int IdAdmin {get; set;}
    
    [Required(ErrorMessage = "Document is required")]
    [MaxLength(10,ErrorMessage ="Document is too long")]
    public string Document { get; set; }
    
    [Required(ErrorMessage = "Password is required")] 
    [MaxLength(50,ErrorMessage ="Password is too long")]
    public string Password {get; set;}
    
    public virtual ICollection<TicketRegister>? TicketRegisters { get; set; }
    public virtual ICollection<Ticket>? Tickets { get; set; }
    public virtual ICollection<ServiceHistory>? ServiceHistories { get; set; }
    
}