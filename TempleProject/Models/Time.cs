using System;
using System.ComponentModel.DataAnnotations;

namespace TempleProject.Models
{
    public class Time
    {
        [Key]
        [Required]
        public int TimeId { get; set; }

        [Required]
        public string TimeSlot { get; set; }

        [Required]
        public string Day { get; set; }

        [Required]
        public bool IsTaken { get; set; }
    }
}
