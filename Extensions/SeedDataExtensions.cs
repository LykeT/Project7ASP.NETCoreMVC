using Project7ASP.NETCoreMVC.Models;
using Project7ASP.NETCoreMVC.Services;

namespace Project7ASP.NETCoreMVC.Extensions
{
    public static class SeedDataExtensions
    {
        public static void InitSeedData(this IServiceCollection services)
        {
            MovieService._movielist.AddRange(new List<Movie> {
     new Movie("Title 1", 2015, "Director 1"),
     new Movie("Title 2", 2019, "Director 2"),
     new Movie("Title 3", 2020, "Director 3"),
     new Movie("Title 4", 2021, "Director 4"),
     new Movie("Title 5", 2022, "Director 5"),
     new Movie("Title 6", 2023, "Director 6"),
     new Movie("Title 7", 2024, "Director 7"),
     new Movie("Title 8", 2025, "Director 8"),
     new Movie("Title 9", 2026, "Director 9"),
     new Movie("Title 10", 2027, "Director 10")
    });
        }
    }
}
