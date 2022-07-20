namespace GuestBook.Data.DAL.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _dbContext;
        public BaseRepository(DbContext context)
            => _dbContext = context;
        public void Add(T entity)
             => _dbContext.Set<T>().Add(entity);

        public IEnumerable<T> GetAll()
            => _dbContext.Set<T>().ToList(); 

        public int Count() 
            => _dbContext.Set<T>().Count();
        
        public int Save()
            => _dbContext.SaveChanges();
    }
}
