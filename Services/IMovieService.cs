using Project7ASP.NETCoreMVC.Models;

namespace Project7ASP.NETCoreMVC.Services
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        void AddMovie(Movie newMovie);

        Movie GetById(Guid Id);
    }
}
