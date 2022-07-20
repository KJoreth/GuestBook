namespace GuestBook.Extensions
{
    static class ServiceMethodExtensions
    {
        public static void AddCustomServices(this IServiceCollection services, string connectionString) 
        {
            //Database
            services.AddDbContext<GuessBookContext>(options => options.UseSqlServer(connectionString));

            //EntryRepository
            services.AddScoped<IEntryRepository, EntryRepository>();

            //EntryConverter
            services.AddScoped<IEntryConverter, EntryConverter>();

            //EntryHandler
            services.AddScoped<IEntryHandler, EntryHandler>();

            //PaginationHandler
            services.AddScoped<IPaginationHandler, PaginationHandler>();
        }
    }
}
