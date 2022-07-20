namespace GuestBook.Data.DAL.Interfaces
{
    public interface IEntryRepository : IRepository<Entry>
    {
        IEnumerable<Entry> GetRangeOrderByDate(int maxRows, int currentPage);
    }
}
