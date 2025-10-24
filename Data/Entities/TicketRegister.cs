using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SaludLinux.Models;

namespace ShiftManagementSystem.Data.Entities;

public class TicketRegister
{
    [Key]
    public int IdTicketRegister { get; set; }

    public int RegisterNumber { get; set; }

    [Required]
    public string Status { get; set; } = "Open";

    public DateTime OpenDate { get; set; } = DateTime.Now;

    public DateTime? CloseDate { get; set; }
    
    [ForeignKey("Employee")]
    public int IdEmployee { get; set; }
    
    public virtual Employee Employee { get; set; }
    public virtual ICollection<Ticket>? Tickets { get; set; }
}