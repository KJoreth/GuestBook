namespace GuestBook.Data.Convertes
{
    public class EntryConverter : IEntryConverter
    {
        public List<EntryDetailsDTO> ConvertToDetailsDTOs(List<Entry> entries)
        {
            List<EntryDetailsDTO> result = new List<EntryDetailsDTO>();

            foreach (Entry entry in entries)
            {
                EntryDetailsDTO newDTO = new EntryDetailsDTO();
                newDTO.EntryMessage = entry.EntryMessage;
                newDTO.EntryDate = entry.EntryDate;
                newDTO.EntryTitle = entry.EntryTitle;
                newDTO.UserName = entry.UserName;
                newDTO.EntryId = entry.EntryId;
                result.Add(newDTO);
            }

            return result;
        }

        public Entry ConvertToEntry(EntryCreateDTO entryDTO)
        {
            Entry newEntry = new Entry();
            newEntry.EntryMessage = entryDTO.EntryMessage;
            newEntry.EntryTitle = entryDTO.EntryTitle;
            newEntry.Email = entryDTO.Email;
            newEntry.UserName = entryDTO.UserName;
            return newEntry;
        }
    }
}
