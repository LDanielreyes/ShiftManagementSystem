using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShiftManagementSystem.Data.Entities;

namespace SaludLinux.Models
{
    public class Card
    {
        [Key]
        public int IdCard { get; set; }

        [Required, MaxLength(255)]
        public string QrCode { get; set; }

        public DateTime IssueDate { get; set; } = DateTime.Now;
        
        [ForeignKey("Affiliate")]
        public int IdAffiliate { get; set; }
        
        public virtual Affiliate Affiliate { get; set; }
    }
}