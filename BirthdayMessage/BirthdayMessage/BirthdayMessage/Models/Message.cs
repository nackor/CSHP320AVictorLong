using System.ComponentModel.DataAnnotations;

namespace BirthdayMessage.Models
{
    public class Message
    {
        [Required(ErrorMessage = "Please enter who the message is From")]
        public string FromPerson { get; set; }
       
        [Required(ErrorMessage = "Please enter who the message is To")]
        public string ToPerson { get; set; }

       
        [Required(ErrorMessage = "Please enter a message")]
        public string BdayMessage { get; set; }

    }
}
