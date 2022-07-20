namespace GuestBook.Handlers
{
    public class EntryHandler : IEntryHandler
    {
        private readonly IEntryRepository _entryRepository;
        private readonly IEntryConverter _converter;


        public EntryHandler(IEntryRepository entryRepository, IEntryConverter converter)
        {
            _entryRepository = entryRepository;
            _converter = converter;
        }

        public void AddEntry(EntryCreateDTO entry)
        {
            var entryToAdd = _converter.ConvertToEntry(entry);
            _entryRepository.Add(entryToAdd);
            _entryRepository.Save();
        }
    }
}
