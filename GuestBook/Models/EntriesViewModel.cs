namespace GuestBook.Models
{
    public class EntriesViewModel
    {
        public List<EntryDetailsDTO> Entries { get; set; }
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; } 
    }
}
