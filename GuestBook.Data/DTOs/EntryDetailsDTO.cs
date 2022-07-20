namespace GuestBook.Data.DTO
{
    public class EntryDetailsDTO
    {
        public int EntryId { get; set; }
        public string UserName { get; set; }
        public string EntryTitle { get; set; }
        public string EntryMessage { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
