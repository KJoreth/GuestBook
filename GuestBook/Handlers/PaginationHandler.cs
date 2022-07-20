namespace GuestBook.Handlers
{

    public class PaginationHandler : IPaginationHandler
    {

        private readonly IConfiguration _config;
        private readonly IEntryRepository _entryRepository;
        private readonly IEntryConverter _converter;


        public PaginationHandler(IEntryRepository entryRepository, IEntryConverter converter, IConfiguration config)
        {
            _config = config;
            _entryRepository = entryRepository;
            _converter = converter;
        }

        public EntriesViewModel GetEntriesForPage(int currentPage)
        {
            int maxRows = _config.GetValue<int>("AppSettings:MaxEntriesOnPage");
            EntriesViewModel model = new EntriesViewModel();

            var entries = _entryRepository.GetRangeOrderByDate(maxRows, currentPage).ToList();
            model.Entries = _converter.ConvertToDetailsDTOs(entries);
            model.PageCount = GetPageCount();
            model.CurrentPageIndex = currentPage;

            return model;
        }

        private int GetPageCount()
        {
            int maxRows = _config.GetValue<int>("AppSettings:MaxEntriesOnPage");
            int entryCount = _entryRepository.Count();

            if (entryCount % maxRows == 0)
                return entryCount / maxRows;

            return entryCount / maxRows + 1;
        }
    }
}
