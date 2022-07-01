using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your fucking name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your fucking email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your fucking phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Well, are you going to fucking join us or not?")]
        public bool? WillAttend { get; set; }
    }
}
