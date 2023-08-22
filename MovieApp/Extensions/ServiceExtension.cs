using Microsoft.EntityFrameworkCore;
using MovieApp.Data;

namespace MovieApp.Extensions
{
    public static class ServiceExtension
    {
        public static void AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var cnnString = configuration.GetConnectionString("movie_app");
            services.AddDbContext<MovieContext>(options =>
            {
                options.UseNpgsql(
                    cnnString, 
                    options =>
                    {
                        options.MigrationsAssembly(typeof(MovieContext).Assembly.ToString());
                        options.EnableRetryOnFailure(3, TimeSpan.FromSeconds(30), null);
                    });
            });
        }
    }
}
