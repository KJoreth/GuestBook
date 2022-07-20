namespace GuestBook.Data.Convertes.Interfaces
{
    public interface IEntryConverter
    {
        List<EntryDetailsDTO> ConvertToDetailsDTOs(List<Entry> entries);
        Entry ConvertToEntry(EntryCreateDTO entryDTO);
    }
}