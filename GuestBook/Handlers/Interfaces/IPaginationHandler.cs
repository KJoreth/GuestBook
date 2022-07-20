namespace GuestBook.Handlers.Interfaces
{
    public interface IPaginationHandler
    {
        EntriesViewModel GetEntriesForPage(int currentPage);
    }
}