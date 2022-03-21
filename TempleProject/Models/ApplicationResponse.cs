using System;
using System.ComponentModel.DataAnnotations;

namespace TempleProject.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int AppointmentID { get; set; }

        [Required(ErrorMessage = "Please enter the name of the group")]
        public string GroupName { get; set; }

        [MaxLength(15)]
        [Required(ErrorMessage = "The size of the group must be between 1 and 15")]
        public int GroupSize { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter an Email address")]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

    }
}
