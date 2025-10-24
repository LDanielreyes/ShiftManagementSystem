using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShiftManagementSystem.Data.Entities;

namespace SaludLinux.Models
{
    public class Ticket
    {
        [Key]
        public int IdTicket { get; set; }

        public int TicketNumber { get; set; }

        public DateTime IssueDate { get; set; } = DateTime.Now;

        [Required]
        public string Status { get; set; } = "Pending";

        // --- Foreign Keys ---
        [ForeignKey("Affiliate")]
        public int IdAffiliate { get; set; }

        [ForeignKey("Employee")]
        public int? IdEmployee { get; set; }

        [ForeignKey("CashRegister")]
        public int? IdCashRegister { get; set; }

        // --- Relationships ---
        public virtual Affiliate Affiliate { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual TicketRegister? TicketRegister { get; set; }
        public virtual ServiceHistory? ServiceHistory { get; set; }
    }
}