using Project7ASP.NETCoreMVC.Models;

namespace Project7ASP.NETCoreMVC.Services
{
    public class MovieService: IMovieService
    {
        public static List<Movie> _movielist { get; set; } = new();

        public List<Movie> GetAllMovies()
        {
            return _movielist;
        }

        public void AddMovie(Movie newMovie)
        {
            _movielist.Add(newMovie);
        }

        public Movie GetById(Guid Id)
        {
            return _movielist.Find(m => m.ID == Id);
        }
}
