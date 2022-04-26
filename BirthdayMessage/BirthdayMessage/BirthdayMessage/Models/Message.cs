using System.ComponentModel.DataAnnotations;

namespace BirthdayMessage.Models
{
    public class Message
    {
        [Required(ErrorMessage = "Please enter who the message is from")]
        public string From { get; set; }
        [Phone]
        [Required(ErrorMessage = "Please enter your phone")]
        public string? Phone { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please enter your email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your willattend")]
        public bool? WillAttend { get; set; }
    }
}
