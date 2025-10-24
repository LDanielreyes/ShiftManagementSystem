using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SaludLinux.Models;

namespace ShiftManagementSystem.Data.Entities
{
    public class ServiceHistory
    {
        [Key]
        public int IdHistory { get; set; }

        public DateTime ServiceDate { get; set; } = DateTime.Now;

        public string? Notes { get; set; }
        
        
        [ForeignKey("Ticket")]
        public int IdTicket { get; set; }

        [ForeignKey("Employee")]
        public int IdEmployee { get; set; }
        
        
        public virtual Ticket Ticket { get; set; }
        public virtual Employee Employee { get; set; }
    }
}