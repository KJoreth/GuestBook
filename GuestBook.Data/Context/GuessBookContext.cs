namespace GuestBook.Data.Context
{
    public class GuessBookContext : DbContext
    {
        public GuessBookContext(DbContextOptions<GuessBookContext> options)
            : base(options) { }
        public DbSet<Entry> Entries { get; set; }
    }
}
