namespace GuestBook.Data.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
        int Count();
        int Save();
    }
}
