using System;
using System.ComponentModel.DataAnnotations;

namespace TempleProject.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int AppointmentID { get; set; }

        [Required]
        public string GroupName { get; set; }

        [MaxLength(15)]
        [Required]
        public int GroupSize { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

    }
}
