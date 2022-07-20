namespace GuestBook.Data.DTO
{
    public class EntryCreateDTO
    {

        [Required(ErrorMessage = "Username required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email required")]
        [EmailAddress(ErrorMessage = "Enter correct email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Message required")]
        [MaxLength(20, ErrorMessage = "Title is too long")]
        public string EntryTitle { get; set; }

        [Required(ErrorMessage = "Message required")]
        [MaxLength(250, ErrorMessage = "Message is too long")]
        public string EntryMessage { get; set; }
    }
}
