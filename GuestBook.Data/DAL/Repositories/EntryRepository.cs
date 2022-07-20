using GuestBook.Data.Context;
using GuestBook.Data.DAL.Interfaces;
namespace GuestBook.Data.DAL.Repositories
{
    public class EntryRepository : BaseRepository<Entry>, IEntryRepository
    {
        public EntryRepository(GuessBookContext context)
            : base(context) { }

        public IEnumerable<Entry> GetRangeOrderByDate(int maxRows, int currentPage)
            => GuessBookContext.Entries
                .AsNoTracking()
                .OrderByDescending(x => x.EntryDate)
                .Skip((currentPage - 1) * maxRows)
                .Take(maxRows);

        public GuessBookContext GuessBookContext 
        {
            get { return _dbContext as GuessBookContext; }
        }
    }
}
